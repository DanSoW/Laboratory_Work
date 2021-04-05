package com.game.changeencoding;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.content.Intent;
import android.net.Uri;
import android.os.Bundle;
import android.os.Environment;
import android.os.FileUtils;
import android.util.Log;
import android.view.View;
import android.widget.AdapterView;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Spinner;
import android.widget.Toast;

import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;
import java.io.Reader;
import java.io.UnsupportedEncodingException;
import java.io.Writer;

public class MainActivity extends AppCompatActivity {

    private EditText _inputUtf8;
    private Button _convertToUtf16;
    private EditText _resultConvertUtf816;
    private EditText _inputUtf16;
    private Button _convertToUtf8;
    private EditText _resultConvertUtf168;
    private Button _chooseFile;
    private Button _coding;
    private Spinner _spinner1;
    private Spinner _spinner2;

    private String fileCoding = "";
    private String fileEncoding = "";

    private static final int FILE_SELECT_CODE = 0;
    private static String filePath = "";


    private void showFileChooser() {
        Intent intent = new Intent(Intent.ACTION_GET_CONTENT);
        intent.setType("*/*");
        intent.addCategory(Intent.CATEGORY_OPENABLE);

        try {
            startActivityForResult(
                    Intent.createChooser(intent, "Выбор файла"),
                    FILE_SELECT_CODE);
        } catch (android.content.ActivityNotFoundException ex) {
            Toast.makeText(this, "Требуется установка файлового менеджера!",
                    Toast.LENGTH_SHORT).show();
            filePath = "";
        }
    }


    private Uri uriUser = null;

    @Override
    protected void onActivityResult(int requestCode, int resultCode, Intent data) {
        switch (requestCode) {
            case FILE_SELECT_CODE:
                if (resultCode == RESULT_OK) {
                    Uri uri = data.getData();
                    filePath = data.getData().getPath();
                    uriUser = uri;
                }
                break;
        }
        super.onActivityResult(requestCode, resultCode, data);
    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        _inputUtf8 = (EditText) findViewById(R.id.inputUtf8);
        _convertToUtf16 = (Button) findViewById(R.id.convertToUtf16);
        _resultConvertUtf816 = (EditText) findViewById(R.id.resultConvertUtf816);
        _inputUtf16 = (EditText) findViewById(R.id.inputUtf16);
        _convertToUtf8 = (Button) findViewById(R.id.convertToUtf8);
        _resultConvertUtf168 = (EditText) findViewById(R.id.resultConvertUtf168);
        _chooseFile = (Button) findViewById(R.id.chooseFile);
        _coding = (Button) findViewById(R.id.coding);
        _spinner1 = (Spinner) findViewById(R.id.spinner1);
        _spinner2 = (Spinner) findViewById(R.id.spinner2);

        _spinner1.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {
            public void onItemSelected(AdapterView<?> parent,
                                       View itemSelected, int selectedItemPosition, long selectedId) {
                String[] choose = getResources().getStringArray(R.array.coding);
                fileCoding = choose[selectedItemPosition];
            }
            public void onNothingSelected(AdapterView<?> parent) {
            }
        });

        _spinner2.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {
            public void onItemSelected(AdapterView<?> parent,
                                       View itemSelected, int selectedItemPosition, long selectedId) {
                String[] choose = getResources().getStringArray(R.array.coding);
                fileEncoding = choose[selectedItemPosition];
            }
            public void onNothingSelected(AdapterView<?> parent) {
            }
        });

        _chooseFile.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                showFileChooser();
            }
        });

        _coding.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                File sdPath = Environment.getExternalStorageDirectory();
                try (final FileInputStream    fileInputStream    = new FileInputStream(sdPath + "/" +
                        filePath.split(":")[1]);
                     final InputStreamReader  inputStreamReader  = new InputStreamReader(fileInputStream, fileCoding);
                     final FileOutputStream   fileOutputStream   = new FileOutputStream(sdPath + "/" +
                             filePath.split(":")[1] + fileEncoding + ".txt");
                     final OutputStreamWriter outputStreamWriter = new OutputStreamWriter(fileOutputStream, fileEncoding))
                {
                    final int BUFFER_SIZE = 2048;
                    final char[] buffer = new char[BUFFER_SIZE];
                    int readed;
                    while ((readed = inputStreamReader.read(buffer, 0, BUFFER_SIZE)) > 0)
                        outputStreamWriter.write(buffer, 0, readed);

                } catch (Exception e) {
                    e.printStackTrace();
                }
            }
        });

        _convertToUtf16.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                if(_inputUtf8.getText().toString().length() == 0){
                    Toast.makeText(MainActivity.this, "Ошибка: отсутствует текст, который нужно перевести из " +
                            "кодировки UTF-8 в UTF-16", Toast.LENGTH_LONG).show();
                    return;
                }

                String textInUtf16 = _inputUtf8.getText().toString();
                try {
                    byte[] utf8 = textInUtf16.getBytes("UTF-8");
                    String textInUtf8 = new String(utf8, "UTF-8");
                    byte[] utf16 = textInUtf8.getBytes("UTF-16LE");

                    _resultConvertUtf816.setText(new String(utf16, "UTF-16LE"));
                } catch (UnsupportedEncodingException e) {
                    e.printStackTrace();
                }
            }
        });

        _convertToUtf8.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                if(_inputUtf16.getText().toString().length() == 0){
                    Toast.makeText(MainActivity.this, "Ошибка: отсутствует текст, который нужно перевести из " +
                            "кодировки UTF-16LE в UTF-8", Toast.LENGTH_LONG).show();
                    return;
                }

                String textInUtf16 = _inputUtf16.getText().toString();
                try{
                    byte[] utf8 = textInUtf16.getBytes("UTF-8");
                    String textInUtf8 = new String(utf8, "UTF-8");
                    _resultConvertUtf168.setText(textInUtf8);
                } catch (UnsupportedEncodingException e) {
                    e.printStackTrace();
                }
            }
        });
    }
}
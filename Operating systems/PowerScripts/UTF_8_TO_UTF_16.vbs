'Скрипт перевода текста из кодировки UTF-8 в кодировку UTF-16LE
Set stream = CreateObject("ADODB.Stream")

stream.Type = 2
stream.Charset = "UTF-8"
stream.Open()
stream.LoadFromFile("UTF-8-FROM.txt")
text = stream.ReadText()
stream.Close()

stream.Charset = "UTF-16LE"
stream.Open()
stream.WriteText(text)
stream.SaveToFile "UTF-16-TO.txt", 2
stream.Close()




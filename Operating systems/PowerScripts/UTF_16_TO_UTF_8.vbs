'Скрипт перевода текста из кодировки UTF-16LE в кодировку UTF-8
Set stream = CreateObject("ADODB.Stream")

stream.Type = 2
stream.Charset = "UTF-16LE"
stream.Open()
stream.LoadFromFile("UTF-16-FROM.txt")
text = stream.ReadText()
stream.Close()

stream.Charset = "UTF-8"
stream.Open()
stream.WriteText(text)
stream.SaveToFile "UTF-8-TO.txt", 2
stream.Close()




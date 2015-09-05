# AQA.pinger
MS Visual Studio 2010

Дело писалось в 2011 году, так что давно устарело, но по прежнему работает.

# API
Принцип работы прост:
* Запрос на https://www.aqa.ru/forum/aqatid.php возвращает время последнего ответа на форуме
```
<aquareader>
    <tid>1441491429</tid>
</aquareader>
```
* Запрос на https://www.aqa.ru/forum/aqareader.php?last=$tid возвращает список тем, обновленных с момента $tid
* Если $tid не указан, то возвращаются темы за сутки.
```
<aquareader>
    <post>
        <tid>292800</tid>
        <repl>0</repl>
        <author>d13andrey</author>
        <name>Продаю: Аквариум оргстекло 500 л</name>
        <forum>Аквариумы и оборудование.</forum>
        <date>06-09-2015 00:31:46</date>
    </post>
<aquareader>
```

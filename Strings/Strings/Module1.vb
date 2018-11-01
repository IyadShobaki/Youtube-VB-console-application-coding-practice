Module Module1

    Sub Main()
        ' Get the string from the user
        Console.WriteLine("Enter a string for us: ")
        Dim s As String = Console.ReadLine
        'Let's do some stuff to the string
        Console.WriteLine(s)
        'Console.WriteLine("Length of string: " & s.Length)
        'Console.WriteLine("Contains Hello: " & s.Contains("Hello"))
        'Console.WriteLine("EndsWith goodbye: " & s.EndsWith("goodbye"))
        'Console.WriteLine("IndexOf poodle: " & s.IndexOf("poodle"))
        'Console.WriteLine("Insert poodle: " & s.Insert(0, "poodle"))
        'Console.WriteLine("LastIndexOf Hello: " & s.LastIndexOf("Hello"))
        'Console.WriteLine("Remove: " & s.Remove(0, 10))
        '
        'Console.WriteLine("Replace: " & s.Replace("Hello", ""))
        'Console.WriteLine("StartWith Hello " & s.StartsWith("Hello"))
        'Console.WriteLine("SubString first 5 chars: " & s.Substring(0, 5))
        'Console.WriteLine("ToLower: " & s.ToLower())
        'Console.WriteLine("Case Insensitive Contains hello: " & s.ToLower().Contains("hello"))
        'Console.WriteLine("ToUpper: " & s.ToUpper())
        'Console.WriteLine("Trim: " & s.Trim())

        'Replace
        s = s.ToUpper().Replace("POODLE", "")
        'Replace
        s = s.ToUpper().Replace("HELLO", "")
        Console.WriteLine(s)


    End Sub

End Module

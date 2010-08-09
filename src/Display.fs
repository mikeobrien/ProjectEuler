#light

//Console related functions...

module Display

    open System
    open Win32
    open System.Drawing
    
    let private sectionRule = new String('\u2550', Console.WindowWidth - 2)
    let private subSectionRule = new String('\u2500', Console.WindowWidth - 2)

    let Clear () = Console.Clear()

    let SetColors (background:Color) (foreground:Color) =
        let consoleInfo = new Kernel32.CONSOLE_SCREEN_BUFFER_INFO {}
        let hConsoleHandle = Kernel32.GetStdHandle(STD_OUTPUT_HANDLE)
        Kernel32.GetConsoleScreenBufferInfo(hConsoleHandle, &consoleInfo)
   
        let attributes = (short) (bufferInfo.wAttributes & Kernel32.CONSOLE_BACKGROUND)
        let attributes = (short) (((ushort) attributes) | ((ushort) color))
        Kernel32.SetConsoleTextAttribute(hConsoleHandle, attributes)

        let attributes = (short) (bufferInfo.wAttributes & Kernel32.CONSOLE_FOREGROUND)
        let attributes = (short) (((ushort) attributes) | ((ushort) color))
        Kernel32.SetConsoleTextAttribute(hConsoleHandle, attributes)
   
   
        Console.BackgroundColor <- background
        Console.ForegroundColor <- foreground
        Console.Clear()

    let PrintHeader () = 
        Console.Write("\u2554" + sectionRule + "\u2557")
    
    let Print (t:obj) =
        let text =
            match t with
            | :? int -> (t :?> int).ToString("#,###")
            | :? double -> (t :?> double).ToString("#,###.0")
            | _ -> t.ToString()
        let buffer = new String(' ', Console.WindowWidth - 4 - text.Length)
        Console.Write("\u2551 " + text + buffer + " \u2551")
    
    let PrintTitle (text:System.String) =
        let maxWidth = Console.WindowWidth - 4;
        let leftBuffer = new String('\u2592', ((maxWidth - text.Length) / 2) - 1)
        let rightBuffer = new String('\u2592', ((maxWidth - text.Length) / 2) - ((text.Length + 1) % 2))
        Console.Write("\u2551 " + leftBuffer + " " + text + " " + rightBuffer + " \u2551")
         
    let PrintSectionDivider () = 
        Console.Write("\u2560" + sectionRule + "\u2563")
         
    let PrintSubSectionDivider () = 
        Console.Write("\u255F" + subSectionRule + "\u2562")
         
    let PrintFooter () = 
        Console.Write("\u255A" + sectionRule + "\u255D")
        
    let Pause () = 
        Console.ReadKey() |> ignore
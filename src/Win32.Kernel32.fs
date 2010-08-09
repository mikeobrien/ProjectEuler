module Win32.Kernel32

    open System
    open System.Runtime.InteropServices

    let STD_OUTPUT_HANDLE = -11;
    
    let CONSOLE_FOREGROUND = -16
    let CONSOLE_BACKGROUND = -241

    [<StructLayout(LayoutKind.Sequential)>]
    type COORD =
        val mutable X:int16
        val mutable Y:int16

    [<StructLayout(LayoutKind.Sequential)>]
    type SMALL_RECT =
        val mutable Left:int16
        val mutable Top:int16
        val mutable Right:int16
        val mutable Bottom:int16

    [<StructLayout(LayoutKind.Sequential)>]
    type CONSOLE_SCREEN_BUFFER_INFO =
        val mutable dwSize:COORD
        val mutable dwCursorPosition:COORD
        val mutable wAttributes:int16
        val mutable srWindow:SMALL_RECT
        val mutable dwMaximumWindowSize:COORD
        
    [<DllImport("kernel32.dll", EntryPoint="GetStdHandle", SetLastError=true,
                CharSet=CharSet.Auto,
                CallingConvention=CallingConvention.StdCall)>]
    extern int GetStdHandle(int nStdHandle);

    [<DllImport("kernel32.dll", EntryPoint="GetConsoleScreenBufferInfo",
                SetLastError=true, CharSet=CharSet.Auto,
                CallingConvention=CallingConvention.StdCall)>]
    extern int GetConsoleScreenBufferInfo(int hConsoleOutput,
                     CONSOLE_SCREEN_BUFFER_INFO& lpConsoleScreenBufferInfo);

    [<DllImport("kernel32.dll", SetLastError=true)>]
    extern bool SetConsoleTextAttribute(IntPtr hConsoleOutput, int16 attributes);


using DevComponents.DotNetBar.Keyboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiCLAS.MDE
{
    public static class KeyboardTemplate
    {
        public static Keyboard CreateNumericKeyboard()
        {
            Keyboard keyboard = new Keyboard();

            LinearKeyboardLayout klNumLockOn = new LinearKeyboardLayout();

            //klNumLockOn.AddKey("W");
            //klNumLockOn.AddKey("A");

            //klNumLockOn.AddLine();

            klNumLockOn.AddKey("7");
            klNumLockOn.AddKey("8");
            klNumLockOn.AddKey("9");
            klNumLockOn.AddKey("<-", "{BACKSPACE}", width: 10);

            klNumLockOn.AddLine();

            klNumLockOn.AddKey("4");
            klNumLockOn.AddKey("5");
            klNumLockOn.AddKey("6");
            klNumLockOn.AddKey("-");



            klNumLockOn.AddLine();

            klNumLockOn.AddKey("1");
            klNumLockOn.AddKey("2");
            klNumLockOn.AddKey("3");
            klNumLockOn.AddKey("Enter", "{ENTER}", height: 21, width: 10);
            klNumLockOn.AddLine();

            klNumLockOn.AddKey("0", width: 21);
            klNumLockOn.AddKey(System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            keyboard.Layouts.Add(klNumLockOn);


            return keyboard;
        }

        public static Keyboard CreateAZKeyboard()
        {
            Keyboard keyboard = new Keyboard();

            // Actually there are 4 layout objects, 
            // but for code simplicity this variable is reused for creating each of them.
            LinearKeyboardLayout kc;



            #region Shift modifier pressed

            kc = new LinearKeyboardLayout();
            keyboard.Layouts.Add(kc);    
            
            kc.AddKey("Q");
            kc.AddKey("W");
            kc.AddKey("E");
            kc.AddKey("R");
            kc.AddKey("T");
            kc.AddKey("Y");
            kc.AddKey("U");
            kc.AddKey("I");
            kc.AddKey("O");
            kc.AddKey("P"); 
            kc.AddKey("Backspace", info: "{BACKSPACE}", width: 21);

            kc.AddLine();

            kc.AddSpace(8);
            kc.AddKey("A");
            kc.AddKey("S");
            kc.AddKey("D");
            kc.AddKey("F");
            kc.AddKey("G");
            kc.AddKey("H");
            kc.AddKey("J");
            kc.AddKey("K");
            kc.AddKey("L");
            kc.AddSpace(3);
            kc.AddKey("Enter", info: "{ENTER}", height: 21, width: 21);

            kc.AddLine();

            kc.AddSpace(12);
            kc.AddKey("Z");
            kc.AddKey("X");
            kc.AddKey("C");
            kc.AddKey("V");
            kc.AddKey("B");
            kc.AddKey("N");
            kc.AddKey("M");
           // kc.AddKey("#");

            kc.AddLine();

            kc.AddKey("123", info: "", style: KeyStyle.Dark, layout: 1);
            kc.AddKey(" ", width: 98);            
            kc.AddKey("<", info: "{LEFT}", style: KeyStyle.Dark);
            kc.AddKey(">", info: "{RIGHT}", style: KeyStyle.Dark);

            kc = new LinearKeyboardLayout();
            keyboard.Layouts.Add(kc);    

            //klNumLockOn.AddKey("W");
            //klNumLockOn.AddKey("A");

            //klNumLockOn.AddLine();

            kc.AddKey("7");
            kc.AddKey("8");
            kc.AddKey("9");
            kc.AddKey("<-", "{BACKSPACE}", width: 10);

            kc.AddLine();

            kc.AddKey("4");
            kc.AddKey("5");
            kc.AddKey("6");




            kc.AddLine();

            kc.AddKey("1");
            kc.AddKey("2");
            kc.AddKey("3");
            kc.AddKey("Enter", "{ENTER}", height: 21, width: 10);
            kc.AddLine();
            kc.AddKey("123", info: "", style: KeyStyle.Pressed, layout: KeyboardLayout.PreviousLayout);
            kc.AddKey("0");
          //  kc.AddKey("#");         

            #endregion


            return keyboard;
        }

        public static Keyboard CreateAZ19KeyboardEx()
        {
            Keyboard keyboard = new Keyboard();

            // Actually there are 4 layout objects, 
            // but for code simplicity this variable is reused for creating each of them.
            LinearKeyboardLayout kc;

            #region Normal style configuration (no modifier keys pressed)

            kc = new LinearKeyboardLayout();
            keyboard.Layouts.Add(kc);

            kc.AddKey("Q");
            kc.AddKey("W");
            kc.AddKey("E");
            kc.AddKey("R");
            kc.AddKey("T");
            kc.AddKey("Y");
            kc.AddKey("U");
            kc.AddKey("I");
            kc.AddKey("O");
            kc.AddKey("P");
            kc.AddKey("Backspace", info: "{BACKSPACE}", width: 21);

            kc.AddLine();
            kc.AddSpace(4);

            kc.AddKey("A");
            kc.AddKey("S");
            kc.AddKey("D");
            kc.AddKey("F");
            kc.AddKey("G");
            kc.AddKey("H");
            kc.AddKey("J");
            kc.AddKey("K");
            kc.AddKey("L");
            kc.AddKey("'");
            kc.AddKey("Enter", info: "{ENTER}", height: 21, width: 17);

            kc.AddLine();
         
            kc.AddKey("Z");
            kc.AddKey("X");
            kc.AddKey("C");
            kc.AddKey("V");
            kc.AddKey("B");
            kc.AddKey("N");
            kc.AddKey("M");
            kc.AddKey(",");
            kc.AddKey(".");
            kc.AddKey("?");       

            kc.AddLine();

         
            kc.AddKey("&123", info: "", style: KeyStyle.Dark, layout: 1);
                 
            kc.AddKey(" ", width: 98);
            kc.AddKey("<", info: "{LEFT}", style: KeyStyle.Dark);
            kc.AddKey(">", info: "{RIGHT}", style: KeyStyle.Dark);

            #endregion           

            #region Symbols and numbers (&123) modifier pressed

            kc = new LinearKeyboardLayout();
            keyboard.Layouts.Add(kc);

            kc.AddKey("!");
            kc.AddKey("@");
            kc.AddKey("#");
            kc.AddKey("$");
            kc.AddKey("½");
            kc.AddKey("-");
            kc.AddKey("+", info: "{+}");

            kc.AddSpace(5);

            kc.AddKey("7");
            kc.AddKey("8");
            kc.AddKey("9");            

            kc.AddKey("Bcks", info: "{BACKSPACE}", width: 21);

            kc.AddLine();

            // second line
            kc.AddKey(";");
            kc.AddKey(":");
            kc.AddKey("\"");
            kc.AddKey("%", info: "{%}");
            kc.AddKey("&");
            kc.AddKey("/");
            kc.AddKey("*");

            kc.AddSpace(5);

            kc.AddKey("4");
            kc.AddKey("5");
            kc.AddKey("6");

            

           

            kc.AddLine();

            // third line
            kc.AddKey("(", info: "{(}");
            kc.AddKey(")", info: "{)}");
            kc.AddKey("[", info: "{[}");
            kc.AddKey("]", info: "{]}");
            kc.AddKey("_");
            kc.AddKey("\\");
            kc.AddKey("=");

            kc.AddSpace(5);

            kc.AddKey("1");
            kc.AddKey("2");
            kc.AddKey("3");

            kc.AddKey("Enter", info: "{ENTER}", height: 21, width: 21);

            kc.AddSpace(5);            

            kc.AddLine();
       
            kc.AddKey("&123", info: "", style: KeyStyle.Pressed, layout: KeyboardLayout.PreviousLayout);
        
            kc.AddKey("<", info: "{LEFT}", style: KeyStyle.Dark);
            kc.AddKey(">", info: "{RIGHT}", style: KeyStyle.Dark);
            kc.AddKey("Space", info: "^ ", width: 43);

            kc.AddSpace(5);

            kc.AddKey("0", width: 21);
            
            kc.AddKey(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            kc.AddSpace(5);

            kc.AddLine();

            #endregion

        

            return keyboard;
        }

        public static Keyboard CreateDefaultKeyboard()
        {
            Keyboard keyboard = new Keyboard();

            LinearKeyboardLayout kc; // Actually there are 4 layout objects, but for code simplicity this variable is reused for creating each of them.

            #region Normal style configuration (no modifier keys pressed)

            kc = new LinearKeyboardLayout();
            keyboard.Layouts.Add(kc);

            kc.AddKey("q");
            kc.AddKey("w");
            kc.AddKey("e");
            kc.AddKey("r");
            kc.AddKey("t");
            kc.AddKey("y");
            kc.AddKey("u");
            kc.AddKey("i");
            kc.AddKey("o");
            kc.AddKey("p");
            kc.AddKey("Backspace", info: "{BACKSPACE}", width: 21);

            kc.AddLine();
            kc.AddSpace(4);

            kc.AddKey("a");
            kc.AddKey("s");
            kc.AddKey("d");
            kc.AddKey("f");
            kc.AddKey("g");
            kc.AddKey("h");
            kc.AddKey("j");
            kc.AddKey("k");
            kc.AddKey("l");
            kc.AddKey("'");
            kc.AddKey("Enter", info: "{ENTER}", width: 17);

            kc.AddLine();

            kc.AddKey("Shift", info: "", style: KeyStyle.Dark, layout: 1);
            kc.AddKey("z");
            kc.AddKey("x");
            kc.AddKey("c");
            kc.AddKey("v");
            kc.AddKey("b");
            kc.AddKey("n");
            kc.AddKey("m");
            kc.AddKey(",");
            kc.AddKey(".");
            kc.AddKey("?");
            kc.AddKey("Shift", info: "", style: KeyStyle.Dark, layout: 1);

            kc.AddLine();

            kc.AddKey("Ctrl", info: "", style: KeyStyle.Dark, layout: 2);
            kc.AddKey("&123", info: "", style: KeyStyle.Dark, layout: 3);
            kc.AddKey(":-)", info: ":-{)}", style: KeyStyle.Dark);
            //kc.AddKey("Alt", info: "%", style: KeyStyle.Dark);
            kc.AddKey(" ", width: 76);
            kc.AddKey("<", info: "{LEFT}", style: KeyStyle.Dark);
            kc.AddKey(">", info: "{RIGHT}", style: KeyStyle.Dark);

            #endregion

            #region Shift modifier pressed

            kc = new LinearKeyboardLayout();
            keyboard.Layouts.Add(kc);

            kc.AddKey("Q", layout: KeyboardLayout.PreviousLayout);
            kc.AddKey("W", layout: KeyboardLayout.PreviousLayout);
            kc.AddKey("E", layout: KeyboardLayout.PreviousLayout);
            kc.AddKey("R", layout: KeyboardLayout.PreviousLayout);
            kc.AddKey("T", layout: KeyboardLayout.PreviousLayout);
            kc.AddKey("Y", layout: KeyboardLayout.PreviousLayout);
            kc.AddKey("U", layout: KeyboardLayout.PreviousLayout);
            kc.AddKey("I", layout: KeyboardLayout.PreviousLayout);
            kc.AddKey("O", layout: KeyboardLayout.PreviousLayout);
            kc.AddKey("P", layout: KeyboardLayout.PreviousLayout);
            kc.AddKey("Backspace", info: "{BACKSPACE}", width: 21);

            kc.AddLine();
            kc.AddSpace(4);

            kc.AddKey("A", layout: KeyboardLayout.PreviousLayout);
            kc.AddKey("S", layout: KeyboardLayout.PreviousLayout);
            kc.AddKey("D", layout: KeyboardLayout.PreviousLayout);
            kc.AddKey("F", layout: KeyboardLayout.PreviousLayout);
            kc.AddKey("G", layout: KeyboardLayout.PreviousLayout);
            kc.AddKey("H", layout: KeyboardLayout.PreviousLayout);
            kc.AddKey("J", layout: KeyboardLayout.PreviousLayout);
            kc.AddKey("K", layout: KeyboardLayout.PreviousLayout);
            kc.AddKey("L", layout: KeyboardLayout.PreviousLayout);
            kc.AddKey("\"", layout: KeyboardLayout.PreviousLayout);
            kc.AddKey("Enter", info: "{ENTER}", width: 17);

            kc.AddLine();

            kc.AddKey("Shift", info: "", style: KeyStyle.Pressed, layout: 0, layoutEx: 4);
            kc.AddKey("Z", layout: KeyboardLayout.PreviousLayout);
            kc.AddKey("X", layout: KeyboardLayout.PreviousLayout);
            kc.AddKey("C", layout: KeyboardLayout.PreviousLayout);
            kc.AddKey("V", layout: KeyboardLayout.PreviousLayout);
            kc.AddKey("B", layout: KeyboardLayout.PreviousLayout);
            kc.AddKey("N", layout: KeyboardLayout.PreviousLayout);
            kc.AddKey("M", layout: KeyboardLayout.PreviousLayout);
            kc.AddKey(";", layout: KeyboardLayout.PreviousLayout);
            kc.AddKey(":", layout: KeyboardLayout.PreviousLayout);
            kc.AddKey("!", layout: KeyboardLayout.PreviousLayout);
            kc.AddKey("Shift", info: "", style: KeyStyle.Pressed, layout: 0, layoutEx: 4);

            kc.AddLine();

            kc.AddKey("Ctrl", info: "", style: KeyStyle.Dark, layout: 2);
            kc.AddKey("&123", info: "", style: KeyStyle.Dark, layout: 3);
            kc.AddKey(":-)", info: ":-{)}", style: KeyStyle.Dark, layout: KeyboardLayout.PreviousLayout);
            kc.AddKey(" ", width: 76, layout: KeyboardLayout.PreviousLayout);
            kc.AddKey("<", info: "+{LEFT}", style: KeyStyle.Dark, layout: KeyboardLayout.PreviousLayout);
            kc.AddKey(">", info: "+{RIGHT}", style: KeyStyle.Dark, layout: KeyboardLayout.PreviousLayout);

            #endregion

            #region Ctrl modifier pressed

            kc = new LinearKeyboardLayout();
            keyboard.Layouts.Add(kc);

            kc.AddKey("q", info: "^q", layout: KeyboardLayout.PreviousLayout);
            kc.AddKey("w", info: "^w", layout: KeyboardLayout.PreviousLayout);
            kc.AddKey("e", info: "^e", layout: KeyboardLayout.PreviousLayout);
            kc.AddKey("r", info: "^r", layout: KeyboardLayout.PreviousLayout);
            kc.AddKey("t", info: "^t", layout: KeyboardLayout.PreviousLayout);
            kc.AddKey("y", info: "^y", layout: KeyboardLayout.PreviousLayout);
            kc.AddKey("u", info: "^u", hint: "Underline", layout: KeyboardLayout.PreviousLayout);
            kc.AddKey("i", info: "^i", hint: "Italic", layout: KeyboardLayout.PreviousLayout);
            kc.AddKey("o", info: "^o", layout: KeyboardLayout.PreviousLayout);
            kc.AddKey("p", info: "^p", layout: KeyboardLayout.PreviousLayout);
            kc.AddKey("Backspace", info: "^{BACKSPACE}", width: 21, layout: KeyboardLayout.PreviousLayout);

            kc.AddLine();
            kc.AddSpace(4);

            kc.AddKey("a", info: "^a", hint: "Select all", layout: KeyboardLayout.PreviousLayout);
            kc.AddKey("s", info: "^s", layout: KeyboardLayout.PreviousLayout);
            kc.AddKey("d", info: "^d", layout: KeyboardLayout.PreviousLayout);
            kc.AddKey("f", info: "^f", layout: KeyboardLayout.PreviousLayout);
            kc.AddKey("g", info: "^g", layout: KeyboardLayout.PreviousLayout);
            kc.AddKey("h", info: "^h", layout: KeyboardLayout.PreviousLayout);
            kc.AddKey("j", info: "^j", layout: KeyboardLayout.PreviousLayout);
            kc.AddKey("k", info: "^k", layout: KeyboardLayout.PreviousLayout);
            kc.AddKey("l", info: "^l", layout: KeyboardLayout.PreviousLayout);
            kc.AddKey("'", info: "^'", layout: KeyboardLayout.PreviousLayout);
            kc.AddKey("Enter", info: "^{ENTER}", width: 17, layout: KeyboardLayout.PreviousLayout);

            kc.AddLine();

            kc.AddKey("Shift", info: "", layout: 1);
            kc.AddKey("z", info: "^z", hint: "Undo", layout: KeyboardLayout.PreviousLayout);
            kc.AddKey("x", info: "^x", hint: "Cut", layout: KeyboardLayout.PreviousLayout);
            kc.AddKey("c", info: "^c", hint: "Copy", layout: KeyboardLayout.PreviousLayout);
            kc.AddKey("v", info: "^v", hint: "Paste", layout: KeyboardLayout.PreviousLayout);
            kc.AddKey("b", info: "^b", hint: "Bold", layout: KeyboardLayout.PreviousLayout);
            kc.AddKey("n", info: "^n", layout: KeyboardLayout.PreviousLayout);
            kc.AddKey("m", info: "^m", layout: KeyboardLayout.PreviousLayout);
            kc.AddKey(",", info: "^,", layout: KeyboardLayout.PreviousLayout);
            kc.AddKey(".", info: "^.", layout: KeyboardLayout.PreviousLayout);
            kc.AddKey("?", info: "^?", layout: KeyboardLayout.PreviousLayout);
            kc.AddKey("Shift", info: "", layout: 1);

            kc.AddLine();

            kc.AddKey("Ctrl", info: "", style: KeyStyle.Pressed, layout: KeyboardLayout.PreviousLayout);
            kc.AddKey("&123", info: "", style: KeyStyle.Dark, layout: 3);
            kc.AddKey(":-)", info: "^:-{)}", style: KeyStyle.Dark, layout: KeyboardLayout.PreviousLayout);
            kc.AddKey(" ", info: "^ ", width: 76, layout: KeyboardLayout.PreviousLayout);
            kc.AddKey("<", info: "^{LEFT}", style: KeyStyle.Dark, layout: KeyboardLayout.PreviousLayout);
            kc.AddKey(">", info: "^{RIGHT}", style: KeyStyle.Dark, layout: KeyboardLayout.PreviousLayout);

            #endregion

            #region Symbols and numbers (&123) modifier pressed

            kc = new LinearKeyboardLayout();
            keyboard.Layouts.Add(kc);

            kc.AddKey("!");
            kc.AddKey("@");
            kc.AddKey("#");
            kc.AddKey("$");
            kc.AddKey("½");
            kc.AddKey("-");
            kc.AddKey("+", info: "{+}");

            kc.AddSpace(5);

            kc.AddKey("1", style: KeyStyle.Light);
            kc.AddKey("2", style: KeyStyle.Light);
            kc.AddKey("3", style: KeyStyle.Light);

            kc.AddSpace(5);

            kc.AddKey("Bcks", info: "{BACKSPACE}", style: KeyStyle.Dark);

            kc.AddLine();

            // second line
            kc.AddKey(";");
            kc.AddKey(":");
            kc.AddKey("\"");
            kc.AddKey("%", info: "{%}");
            kc.AddKey("&");
            kc.AddKey("/");
            kc.AddKey("*");

            kc.AddSpace(5);

            kc.AddKey("4", style: KeyStyle.Light);
            kc.AddKey("5", style: KeyStyle.Light);
            kc.AddKey("6", style: KeyStyle.Light);

            kc.AddSpace(5);

            kc.AddKey("Enter", info: "{ENTER}", style: KeyStyle.Dark);

            kc.AddLine();

            // third line
            kc.AddKey("(", info: "{(}");
            kc.AddKey(")", info: "{)}");
            kc.AddKey("[", info: "{[}");
            kc.AddKey("]", info: "{]}");
            kc.AddKey("_");
            kc.AddKey("\\");
            kc.AddKey("=");

            kc.AddSpace(5);

            kc.AddKey("7", style: KeyStyle.Light);
            kc.AddKey("8", style: KeyStyle.Light);
            kc.AddKey("9", style: KeyStyle.Light);

            kc.AddSpace(5);

            kc.AddKey("Tab", info: "{TAB}", style: KeyStyle.Dark);

            kc.AddLine();

            // forth line
            kc.AddKey("...", style: KeyStyle.Dark, layout: KeyboardLayout.PreviousLayout);
            kc.AddKey("&123", info: "", style: KeyStyle.Pressed, layout: KeyboardLayout.PreviousLayout);
            kc.AddKey(":-)", info: ":-{)}", style: KeyStyle.Dark);
            kc.AddKey("<", info: "{LEFT}", style: KeyStyle.Dark);
            kc.AddKey(">", info: "{RIGHT}", style: KeyStyle.Dark);
            kc.AddKey("Space", info: "^ ", width: 21);

            kc.AddSpace(5);

            kc.AddKey("0", style: KeyStyle.Light, width: 21);
            kc.AddKey(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator, style: KeyStyle.Dark);

            kc.AddSpace(5);

            kc.AddLine();

            #endregion

            #region Shift modifier toggled

            kc = new LinearKeyboardLayout();
            keyboard.Layouts.Add(kc);

            kc.AddKey("Q");
            kc.AddKey("W");
            kc.AddKey("E");
            kc.AddKey("R");
            kc.AddKey("T");
            kc.AddKey("Y");
            kc.AddKey("U");
            kc.AddKey("I");
            kc.AddKey("O");
            kc.AddKey("P");
            kc.AddKey("Backspace", info: "{BACKSPACE}", width: 21);

            kc.AddLine();
            kc.AddSpace(4);

            kc.AddKey("A");
            kc.AddKey("S");
            kc.AddKey("D");
            kc.AddKey("F");
            kc.AddKey("G");
            kc.AddKey("H");
            kc.AddKey("J");
            kc.AddKey("K");
            kc.AddKey("L");
            kc.AddKey("'");
            kc.AddKey("Enter", info: "{ENTER}", width: 17);

            kc.AddLine();

            kc.AddKey("Shift", info: "", style: KeyStyle.Toggled, layout: 0);
            kc.AddKey("Z");
            kc.AddKey("X");
            kc.AddKey("C");
            kc.AddKey("V");
            kc.AddKey("B");
            kc.AddKey("N");
            kc.AddKey("M");
            kc.AddKey(",");
            kc.AddKey(".");
            kc.AddKey("?");
            kc.AddKey("Shift", info: "", style: KeyStyle.Toggled, layout: 0);

            kc.AddLine();

            kc.AddKey("Ctrl", info: "", style: KeyStyle.Dark, layout: 2);
            kc.AddKey("&123", info: "", style: KeyStyle.Dark, layout: 3);
            kc.AddKey(":-)", info: ":-{)}", style: KeyStyle.Dark);
            kc.AddKey(" ", width: 76);
            kc.AddKey("<", info: "+{LEFT}", style: KeyStyle.Dark);
            kc.AddKey(">", info: "+{RIGHT}", style: KeyStyle.Dark);

            #endregion

            return keyboard;
        }
    }
}

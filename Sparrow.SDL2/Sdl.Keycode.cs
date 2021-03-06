﻿using System;
namespace Sparrow.Sdl2
{
    public static partial class Sdl
    {
        
        public const int ScancodeMask = (1 << 30);

        public enum Keycode
        {
            Unknown = 0,

            Return = '\r',
            Escape = 27, // '\033'
            Backspace = '\b',
            Tab = '\t',
            Space = ' ',
            Exclaim = '!',
            DoubleQuote = '"',
            Hash = '#',
            Percent = '%',
            Dollar = '$',
            Ampersand = '&',
            Quote = '\'',
            LeftParenthesisthesis = '(',
            RightParenthesisthesis = ')',
            Asterisk = '*',
            Plus = '+',
            Comma = ',',
            Minus = '-',
            Period = '.',
            Slash = '/',
            Zero = '0',
            One = '1',
            Two = '2',
            Three = '3',
            Four = '4',
            Five = '5',
            Six = '6',
            Seven = '7',
            Eight = '8',
            Nine = '9',
            Colon = ':',
            SemiColon = ';',
            Less = '<',
            Equals = '=',
            Greater = '>',
            Question = '?',
            At = '@',

            LeftBracket = '[',
            Backslash = '\\',
            RightBracket = ']',
            Caret = '^',
            Underscore = '_',
            Backquote = '`',
            A = 'a',
            B = 'b',
            C = 'c',
            D = 'd',
            E = 'e',
            F = 'f',
            G = 'g',
            H = 'h',
            I = 'i',
            J = 'j',
            K = 'k',
            L = 'l',
            M = 'm',
            N = 'n',
            O = 'o',
            P = 'p',
            Q = 'q',
            R = 'r',
            S = 's',
            T = 't',
            U = 'u',
            V = 'v',
            W = 'w',
            X = 'x',
            Y = 'y',
            Z = 'z',

            Capslock = Scancode.Capslock | ScancodeMask,

            F1 = Scancode.F1 | ScancodeMask,
            F2 = Scancode.F2 | ScancodeMask,
            F3 = Scancode.F3 | ScancodeMask,
            F4 = Scancode.F4 | ScancodeMask,
            F5 = Scancode.F5 | ScancodeMask,
            F6 = Scancode.F6 | ScancodeMask,
            F7 = Scancode.F7 | ScancodeMask,
            F8 = Scancode.F8 | ScancodeMask,
            F9 = Scancode.F9 | ScancodeMask,
            F10 = Scancode.F10 | ScancodeMask,
            F11 = Scancode.F11 | ScancodeMask,
            F12 = Scancode.F12 | ScancodeMask,

            PrintScreen = Scancode.PrintScreen | ScancodeMask,
            ScrollLock = Scancode.ScrollLock | ScancodeMask,
            Pause = Scancode.Pause | ScancodeMask,
            Insert = Scancode.Insert | ScancodeMask,
            Home = Scancode.Home | ScancodeMask,
            PageUp = Scancode.PageUp | ScancodeMask,
            Delete = 127,
            End = Scancode.End | ScancodeMask,
            PageDown = Scancode.PageDown | ScancodeMask,
            Right = Scancode.Right | ScancodeMask,
            Left = Scancode.Left | ScancodeMask,
            Down = Scancode.Down | ScancodeMask,
            Up = Scancode.Up | ScancodeMask,

            NumLockClear = Scancode.NumLockClear | ScancodeMask,
            KeypadDivide = Scancode.KeypadDivide | ScancodeMask,
            KeypadMultiply = Scancode.KeypadMultiply | ScancodeMask,
            KeypadMinus = Scancode.KeypadMinus | ScancodeMask,
            KeypadPlus = Scancode.KeypadPlus | ScancodeMask,
            KeypadEnter = Scancode.KeypadEnter | ScancodeMask,
            Keypad1 = Scancode.Keypad1 | ScancodeMask,
            Keypad2 = Scancode.Keypad2 | ScancodeMask,
            Keypad3 = Scancode.Keypad3 | ScancodeMask,
            Keypad4 = Scancode.Keypad4 | ScancodeMask,
            Keypad5 = Scancode.Keypad5 | ScancodeMask,
            Keypad6 = Scancode.Keypad6 | ScancodeMask,
            Keypad7 = Scancode.Keypad7 | ScancodeMask,
            Keypad8 = Scancode.Keypad8 | ScancodeMask,
            Keypad9 = Scancode.Keypad9 | ScancodeMask,
            Keypad0 = Scancode.Keypad0 | ScancodeMask,
            KeypadPeriod = Scancode.KeypadPeriod | ScancodeMask,

            Application = Scancode.Application | ScancodeMask,
            Power = Scancode.Power | ScancodeMask,
            KeypadEquals = Scancode.KeypadEquals | ScancodeMask,
            F13 = Scancode.F13 | ScancodeMask,
            F14 = Scancode.F14 | ScancodeMask,
            F15 = Scancode.F15 | ScancodeMask,
            F16 = Scancode.F16 | ScancodeMask,
            F17 = Scancode.F17 | ScancodeMask,
            F18 = Scancode.F18 | ScancodeMask,
            F19 = Scancode.F19 | ScancodeMask,
            F20 = Scancode.F20 | ScancodeMask,
            F21 = Scancode.F21 | ScancodeMask,
            F22 = Scancode.F22 | ScancodeMask,
            F23 = Scancode.F23 | ScancodeMask,
            F24 = Scancode.F24 | ScancodeMask,
            Execute = Scancode.Execute | ScancodeMask,
            Help = Scancode.Help | ScancodeMask,
            Menu = Scancode.Menu | ScancodeMask,
            Select = Scancode.Select | ScancodeMask,
            Stop = Scancode.Stop | ScancodeMask,
            Again = Scancode.Again | ScancodeMask,
            Undo = Scancode.Undo | ScancodeMask,
            Cut = Scancode.Cut | ScancodeMask,
            Copy = Scancode.Copy | ScancodeMask,
            Paste = Scancode.Paste | ScancodeMask,
            Find = Scancode.Find | ScancodeMask,
            Mute = Scancode.Mute | ScancodeMask,
            VolumeUp = Scancode.VolumeUp | ScancodeMask,
            VolumeDown = Scancode.VolumeDown | ScancodeMask,
            KeypadComma = Scancode.KeypadComma | ScancodeMask,
            KeypadEqualsAs400 = Scancode.KeypadEqualsAs400 | ScancodeMask,

            AltErase = Scancode.AltErase | ScancodeMask,
            SysReq = Scancode.SysReq | ScancodeMask,
            Cancel = Scancode.Cancel | ScancodeMask,
            Clear = Scancode.Clear | ScancodeMask,
            Prior = Scancode.Prior | ScancodeMask,
            Return2 = Scancode.Return2 | ScancodeMask,
            Separator = Scancode.Separator | ScancodeMask,
            Out = Scancode.Out | ScancodeMask,
            Oper = Scancode.Oper | ScancodeMask,
            ClearAgain = Scancode.ClearAgain | ScancodeMask,
            CrSel = Scancode.CrSel | ScancodeMask,
            ExSel = Scancode.ExSel | ScancodeMask,

            Keypad00 = Scancode.Keypad00 | ScancodeMask,
            Keypad000 = Scancode.Keypad000 | ScancodeMask,
            ThousandsSeparator = Scancode.ThousandsSeparator | ScancodeMask,
            DecimalSeparator = Scancode.DecimalSeparator | ScancodeMask,
            CurrencyUnit = Scancode.CurrencyUnit | ScancodeMask,
            CurrencySubunit = Scancode.CurrencySubunit | ScancodeMask,
            KeypadLeftParenthesis = Scancode.KeypadLeftParenthesis | ScancodeMask,
            KeypadRightParenthesis = Scancode.KeypadRightParenthesis | ScancodeMask,
            KeypadLeftBrace = Scancode.KeypadLeftBrace | ScancodeMask,
            KeypadRightBrace = Scancode.KeypadRightBrace | ScancodeMask,
            KeypadTab = Scancode.KeypadTab | ScancodeMask,
            KeypadBackspace = Scancode.KeypadBackspace | ScancodeMask,
            KeypadA = Scancode.KeypadA | ScancodeMask,
            KeypadB = Scancode.KeypadB | ScancodeMask,
            KeypadC = Scancode.KeypadC | ScancodeMask,
            KeypadD = Scancode.KeypadD | ScancodeMask,
            KeypadE = Scancode.KeypadE | ScancodeMask,
            KeypadF = Scancode.KeypadF | ScancodeMask,
            KeypadXor = Scancode.KeypadXor | ScancodeMask,
            KeypadPower = Scancode.KeypadPower | ScancodeMask,
            KeypadPercent = Scancode.KeypadPercent | ScancodeMask,
            KeypadLess = Scancode.KeypadLess | ScancodeMask,
            KeypadGreater = Scancode.KeypadGreater | ScancodeMask,
            KeypadAmpersand = Scancode.KeypadAmpersand | ScancodeMask,
            KeypadDoubleAmpersand = Scancode.KeypadDoubleAmpersand | ScancodeMask,
            KeypadVerticalBar = Scancode.KeypadVerticalBar | ScancodeMask,
            KeypadDoubleVerticalBar = Scancode.KeypadDoubleVerticalBar | ScancodeMask,
            KeypadColon = Scancode.KeypadColon | ScancodeMask,
            KeypadHash = Scancode.KeypadHash | ScancodeMask,
            KeypadSpace = Scancode.KeypadSpace | ScancodeMask,
            KeypadAt = Scancode.KeypadAt | ScancodeMask,
            KeypadExclamation = Scancode.KeypadExclamation | ScancodeMask,
            KeypadMemStore = Scancode.KeypadMemStore | ScancodeMask,
            KeypadMemRecall = Scancode.KeypadMemRecall | ScancodeMask,
            KeypadMemClear = Scancode.KeypadMemClear | ScancodeMask,
            KeypadMemAdd = Scancode.KeypadMemAdd | ScancodeMask,
            KeypadMemSubtract = Scancode.KeypadMemSubtract | ScancodeMask,
            KeypadMemMultiply = Scancode.KeypadMemMultiply | ScancodeMask,
            KeypadMemDivide = Scancode.KeypadMemDivide | ScancodeMask,
            KeypadPlusMinus = Scancode.KeypadPlusMinus | ScancodeMask,
            KeypadClear = Scancode.KeypadClear | ScancodeMask,
            KeypadClearEntry = Scancode.KeypadClearEntry | ScancodeMask,
            KeypadBinary = Scancode.KeypadBinary | ScancodeMask,
            KeypadOctal = Scancode.KeypadOctal | ScancodeMask,
            KeypadDecimal = Scancode.KeypadDecimal | ScancodeMask,
            KeypadHexadecimal =
            Scancode.KeypadHexadecimal | ScancodeMask,

            LeftCtrl = Scancode.LeftCtrl | ScancodeMask,
            LeftShift = Scancode.LeftShift | ScancodeMask,
            LeftAlt = Scancode.LeftAlt | ScancodeMask,
            LeftMeta = Scancode.LeftMeta | ScancodeMask,
            RightCtrl = Scancode.RightCtrl | ScancodeMask,
            RightShift = Scancode.RightShift | ScancodeMask,
            RightAlt = Scancode.RightAlt | ScancodeMask,
            RightMeta = Scancode.RightMeta | ScancodeMask,

            Mode = Scancode.Mode | ScancodeMask,

            AudioNext = Scancode.AudioNext | ScancodeMask,
            AudioPrevious = Scancode.AudioPrevious | ScancodeMask,
            AudioStop = Scancode.AudioStop | ScancodeMask,
            AudioPlay = Scancode.AudioPlay | ScancodeMask,
            AudioMute = Scancode.AudioMute | ScancodeMask,
            MediaSelect = Scancode.MediaSelect | ScancodeMask,
            Www = Scancode.Www | ScancodeMask,
            Mail = Scancode.Mail | ScancodeMask,
            Calculator = Scancode.Calculator | ScancodeMask,
            Computer = Scancode.Computer | ScancodeMask,
            ApplicationControlSearch = Scancode.ApplicationControlSearch | ScancodeMask,
            ApplicationControlHome = Scancode.ApplicationControlHome | ScancodeMask,
            ApplicationControlBack = Scancode.ApplicationControlBack | ScancodeMask,
            ApplicationControlForward = Scancode.ApplicationControlForward | ScancodeMask,
            ApplicationControlStop = Scancode.ApplicationControlStop | ScancodeMask,
            ApplicationControlRefresh = Scancode.ApplicationControlRefresh | ScancodeMask,
            ApplicationControlBookmarks = Scancode.ApplicationControlBookmarks | ScancodeMask,

            BrightnessDown = Scancode.BrightnessDown | ScancodeMask,
            BrightnessUp = Scancode.BrightnessUp | ScancodeMask,
            DisplaySwitch = Scancode.DisplaySwitch | ScancodeMask,
            KeyboadIlluminationToggle = Scancode.KeyboardIlluminationToggle | ScancodeMask,
            KeyboadIlluminationDown = Scancode.KeyboardIlluminationDown | ScancodeMask,
            KeyboadIlluminationUp = Scancode.KeyboardIlluminationUp | ScancodeMask,
            Eject = Scancode.Eject | ScancodeMask,
            Sleep = Scancode.Sleep | ScancodeMask
        }

        [Flags]
        public enum KeyModifier : ushort
        {
            None = 0x0000,
            LeftShift = 0x0001,
            RightShift = 0x0002,
            LeftCtrl = 0x0040,
            RightCtrl = 0x0080,
            LeftAlt = 0x0100,
            RightAlt = 0x0200,
            LeftMeta = 0x0400,
            RightMeta = 0x0800,
            Num = 0x1000,
            Caps = 0x2000,
            Mode = 0x4000,
            Reserved = 0x8000,

            Ctrl = LeftCtrl | RightCtrl,
            Shift = LeftShift | RightShift,
            Alt = LeftAlt | RightAlt,
            Meta = LeftMeta | RightMeta
        }
    }
}

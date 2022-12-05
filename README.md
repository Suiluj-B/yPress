# yPress
Tool to send custom Keyboardstrokes to any application via a hotkey. The program emulates real keyboard presses as if they were sent by hardware. The input is randomly delayed for a few milliseconds to make it look more like human input.

You can specify one Process-ID to focus its main window, send a custom key, and return to another Process-ID's main window afterwards.

Hotkey is set on the right side, keys that should be sent to the focused main window are in the text boxes.

The program watches all keyboard inputs as soon as you start it. It only enables the hotkeys to function when activated on the top right.

There are chains of events hardcoded with no option to change them via the UI. These were used for a specific purpose and can only be changed in the code itself, this was an easier fix at the time.

If you want to edit these hardcoded keys or their modifier, you can find them in Form1.cs in "SendToMainClient".

Canterlot Avenue Mobile App
===========================

### Description

Xamarin Forms app written in Visual Studio for Mac. No special installation should be required beyond Xamarin and VS.
Open the `CanterlotAvenue.sln` file in VS to begin editing.

### Layout

Webview and app logic is in the shared codebase. Platform specific code will be in their respective codebases to handle receiving and registering for push notifications (not currently implemented).
Another codebase may be added here to for the server-side handling of notification registration, detection, pushing e.g.

### Random thoughts

I'm thinking a custom login page to present app information/store logged in cookies
Then a small UI element to present "app settings"
Like enabling push notifications for the device/user combination
Can even probably do custom themes by overwriting the site HTML e.g.

### Notes

* Official Colours
    * #48194d Purple
    * #d6b03e Yellow/Gold

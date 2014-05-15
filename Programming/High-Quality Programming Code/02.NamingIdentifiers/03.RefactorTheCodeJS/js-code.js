function clickOnTheButton(Event, arguments) {
    var windowElement = window;
    var browser = windowElement.navigator.appCodeName;
    var isMozilla = browser === "Mozilla";
    if (isMozilla) {
        alert("Yes");
    } else {
        alert("No");
    }
}
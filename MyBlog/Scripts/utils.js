$(document).ready(function () {
    // Determine timezone offset in milliseconds
    // from: http://www.w3schools.com/jsref/jsref_getTimezoneOffset.asp
    alert("Hi");
    var d = new Date()
    var offsetms = d.getTimezoneOffset() * 60 * 1000;
    $('.posted-date').each(function () {
        try {
            var text = $(this).html();

            var n = new Date(text);
            n = new Date(n.valueOf() - offsetms);

            $(this).html(n.toDateString() + " " + n.toLocaleTimeString());

            //$(this).attr("Converted from UTC " + text);
        }
        catch (ex) {
            console.warn("Error converting time", ex);
        }
    });
});
function getRectArea(width, height) {
    debugger;
    if (isNaN(width) || isNaN(height)) {
        throw new Error('Parameter is not a number!');
    }
    var result = width * height;
    document.getElementById('result').innerText = 'The area is: ' + result;
}

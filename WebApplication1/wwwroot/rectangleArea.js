function getRectArea(width, height) {
    if (isNaN(width) || isNaN(height)) {
        throw new DOMException('Parameter is not a number!');
        throw new Error('Parameter is not a number!');
    }
    var result = width * height;
    document.getElementById('result').innerText = 'The area is: ' + result;
}

function readSingleFile(event) {
    //Retrieve the first (and only!) File from the FileList object
    var file = event.target.files[0];

    if (file) {
        var reader = new FileReader();
        reader.onload = function (e) {
            var contents = e.target.result;            
            var words = contents.toString().split("\n");
            console.log(words[0]);
            var word = 'aardvark';
            console.log(words[1]);
            var checkword = words.indexOf(word);
            if (words.indexOf(word) !== -1) {
                return alert('true');
            }else{
                return alert ('false');
            }

        }
        reader.readAsText(file);
    } else {
        alert("Failed to load file");
    }
}

document.getElementById('files').addEventListener('change', readSingleFile, false);
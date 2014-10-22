function createImagesPreviewer(selector, items) {

    var container = document.querySelector(selector);
    container.style.textAlign = 'right';
    container.style.position = 'relative';
    var titles = [];

    for (var i = 0; i < items.length; i++) {
        titles.push(items[i].title);
    }

    var imagesColumn = document.createElement('div');
    imagesColumn.style.width = '20%';
    imagesColumn.style.float = 'right';
    imagesColumn.style.textAlign='center';
    imagesColumn.style.marginTop = '50px';

    var textField = document.createElement('input');
    textField.setAttribute('type','text');
    textField.setAttribute('id','searchField');
    textField.style.width = '20%';
    textField.style.position='absolute';
    textField.style.top = '25px';
    textField.style.right = '0';
    textField.addEventListener('keyup',changeContent);


    var labelForTextField = document.createElement('label');
    labelForTextField.setAttribute('for','searchField');
    labelForTextField.innerHTML = 'Filter';
    labelForTextField.style.fontSize = '1.1em';
    labelForTextField.style.position='absolute';
    labelForTextField.style.top = '5px';
    labelForTextField.style.right = '9%';


    var bigImage = document.createElement('div');
    bigImage.style.position='fixed';
    bigImage.style.width = '40%';
    bigImage.style.height = '40%';
    bigImage.style.top = '20%';
    bigImage.style.left = '20%';

    var firstBigPic = createAnimalDivs(items[0].title,items[0].url,0);
    firstBigPic.children[1].style.border = '3px solid lightgray';

    bigImage.appendChild(firstBigPic);

    container.appendChild(labelForTextField);
    container.appendChild(textField);
    container.appendChild(bigImage);


    for (var i = 0; i < items.length; i++) {
        var title = items[i].title;
        var url = items[i].url;

        var animalDiv = createAnimalDivs(title,url,i+1);

        imagesColumn.appendChild(animalDiv);
        animalDiv.addEventListener('mouseover',hoverBackground);
        animalDiv.addEventListener('mouseout',restoreBackground);
        animalDiv.addEventListener('click',changePicture);

    }
    function createAnimalDivs(title,url,id){
        var animalDiv = document.createElement('div');
        animalDiv.setAttribute('id',id);
        animalDiv.style.padding = '5px';

        var titleDiv = document.createElement("div");
        titleDiv.innerHTML = title;
        titleDiv.style.textAlign = 'center';
        titleDiv.style.fontWeight = 'bold';

        var img = document.createElement("img");
        img.setAttribute('src',url);
        img.style.borderRadius = "10px";
        img.style.width = '100%';

        animalDiv.appendChild(titleDiv);
        animalDiv.appendChild(img);

        return animalDiv;
    }

    function hoverBackground(ev){
        this.style.backgroundColor = 'lightgrey';
    }
    function restoreBackground(ev){
        this.style.backgroundColor = '';
    }

    function changePicture (ev) {
        bigImage.removeChild(bigImage.children[0]);
        bigImage.appendChild(this.cloneNode(true));
        bigImage.children[0].style.backgroundColor = '';
        bigImage.children[0].children[1].style.border = '3px solid lightgray';
    }

    function changeContent(ev) {
        while(imagesColumn.children[0] != null){
            imagesColumn.removeChild(imagesColumn.children[0]);
        }
        var text = this.value;
        var divsToShow = doesWordExist(text);

        for (var i = 0; i < divsToShow.length; i++) {
            var newDiv = createAnimalDivs(items[divsToShow[i]].title,items[divsToShow[i]].url,i);
            newDiv.addEventListener('mouseover',hoverBackground);
            newDiv.addEventListener('mouseout',restoreBackground);
            newDiv.addEventListener('click',changePicture);
            imagesColumn.appendChild(newDiv);
        }
    }

    function doesWordExist(word) {
        var divsToShow = [];
        for (var i = 0; i < titles.length; i++) {
            var wordInTitle = titles[i].toLowerCase();
            var answer = wordInTitle.indexOf(word);

            if (answer != -1) {
                divsToShow.push(i);
                console.log(i);
            }
        }
        return divsToShow;
    }

    container.appendChild(imagesColumn);
}
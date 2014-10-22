// You are given a text. Write a function that changes the text in all regions:
// <upcase>text</upcase> to uppercase.
// <lowcase>text</lowcase> to lowercase
// <mixcase>text</mixcase> to mix casing(random)

// We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. 
// We <mixcase>don't</mixcase> have <lowcase>anything</lowcase> else.

// The expected result:
// We are LiVinG in a YELLOW SUBMARINE. We dOn'T have anything else.

// Regions can be nested


var inputStr = 'We are <mixcase>living</mixcase> in a <upcase>yellow' +
    ' submarine</upcase>. We <mixcase>don\'t</mixcase> have <lowcase>anything</lowcase> else.';

function removeAdditionalWhiteSpaces(text) {
    return text.replace(/\s{2,}/ig, ' ');
}

function removeAllTags(text) {
    return text.replace(/<.+?case>/ig, '');
}

function applyTags(text, openTagName, closeTagName, action) {
    var openTagIndexes = [];

    var lastOccurance = text.indexOf(openTagName), nextOpenTagIndex, nextCloseTagIndex, originalBlock, updateBlock;
    if (lastOccurance > -1) {
        openTagIndexes.push(lastOccurance);
    }

    while (openTagIndexes.length > 0) {

        lastOccurance = openTagIndexes[openTagIndexes.length - 1];
        nextOpenTagIndex = text.indexOf(openTagName, lastOccurance + openTagName.length);
        nextCloseTagIndex = text.indexOf(closeTagName, lastOccurance + openTagName.length);

        if (nextCloseTagIndex < nextOpenTagIndex || nextOpenTagIndex === -1) {
            originalBlock = text.substring(lastOccurance, nextCloseTagIndex + closeTagName.length);
            updateBlock = removeAllTags(originalBlock);
            updateBlock = removeAdditionalWhiteSpaces(updateBlock);
            updateBlock = action(updateBlock);


            text = text.replace(originalBlock, updateBlock);
            openTagIndexes.pop();

            if (nextOpenTagIndex !== -1 && openTagIndexes.length === 0) {
                openTagIndexes.push(text.indexOf(openTagName, lastOccurance + openTagName.length));
            }

        }
        else {
            openTagIndexes.push(nextOpenTagIndex);
        }
    }

    text = removeAdditionalWhiteSpaces(text).trim();
    return text;
}

function applyUpCaseTags(text) {
    return text.toUpperCase();
}

function applyLowCaseTags(text) {
    return text.toLowerCase();
}

function applyMixCaseTags(text) {
    var result = '', i, tmpRand;
    for (i = 0; i < text.length; ++i) {
        tmpRand = parseInt(Math.random() * 2);
        if (tmpRand === 0) {
            result += text[i].toUpperCase();
        }
        else {
            result += text[i].toLowerCase();
        }
    }
    return result;
}

inputStr = applyTags(inputStr, '<upcase>', '</upcase>', applyUpCaseTags);
inputStr = applyTags(inputStr, '<lowcase>', '</lowcase>', applyLowCaseTags);
inputStr = applyTags(inputStr, '<mixcase>', '</mixcase>', applyMixCaseTags);


console.log(inputStr);

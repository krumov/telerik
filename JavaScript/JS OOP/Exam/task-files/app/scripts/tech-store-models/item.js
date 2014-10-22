define(function () {
    var Item;

    Item = (function () {
        function Item (type,name,price) {
            if (type === 'accessory' || type === 'smart-phone' ||type === 'notebook' ||
                type ===  'pc' ||type === 'tablet'){
                this.type = type;
            }else{
                throw new Error('Type can be only: accessory, smart-phone, notebook, pc or tablet!');
            }

            if (name.length >= 6 && name.length <= 40 && typeof name === 'string'){
                this.name = name;
            }else{
                throw new Error('Name has to be between 6 and 40 chars!');
            }

            if (typeof price  === 'number'){
                this.price = price;
            }else{
                throw new Error('Price has to be a number!');
            }
        }

        return Item;
    }());

    return Item;
});
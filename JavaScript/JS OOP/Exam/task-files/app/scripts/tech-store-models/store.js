define([ 'tech-store-models/item'],function (Item) {
    var Store;

    Store = (function () {
        function Store (title) {
            this.title = title;
            this._items = [];
        }

        function getSortedItemsByType (items, typeOne, typeTwo) {
            var sortedItems = [];

            for (var i = 0, len = items.length; i <len; i++) {
                if( items[i].type === typeOne || items[i].type === typeTwo){
                    sortedItems.push(items[i]);
                }
            }

            return  sortedItems.sort(function(a, b){
                var nameA=a.name.toLowerCase(), nameB=b.name.toLowerCase()
                if (nameA < nameB) //sort string ascending
                    return -1;
                if (nameA > nameB)
                    return 1;
                return 0; //default return value (no sorting)
            });
        }

        Store.prototype.addItem = function (item) {
            if(item instanceof Item){
                this._items.push(item);
            }else{
                throw new Error("You can only add items of type Item!");
            }

            return this;
        };
        Store.prototype.getAll = function () {
          return  this._items.sort(function(itemA, itemB){
                var nameA=itemA.name.toLowerCase(), nameB=itemB.name.toLowerCase();
                if (nameA < nameB) //sort string ascending
                    return -1;
                if (nameA > nameB)
                    return 1;
                return 0; //default return value (no sorting)
            });
        };
        Store.prototype.getSmartPhones = function () {
            return getSortedItemsByType(this._items,'smart-phone');
        };
        Store.prototype.getMobiles = function () {
            return getSortedItemsByType(this._items,'smart-phone','tablet');

        };
        Store.prototype.getComputers = function () {
            return getSortedItemsByType(this._items,'pc','notebook');

        };
        Store.prototype.filterItemsByType = function (filterType) {
            return getSortedItemsByType(this._items,filterType);
        };
        Store.prototype.filterItemsByPrice = function (options) {
            if(!options){
                var options = {};
            }

            var minPrice = options.min || 0,
                maxPrice = options.max || Number.MAX_VALUE,
                sortedItems = [];

            for (var i = 0, len = this._items.length; i < len; i++) {
                var item = this._items[i];
                if(item.price > minPrice && item.price < maxPrice){
                    sortedItems.push(item);
                }
            }

            return sortedItems.sort(function (itemOne,itemTwo) {
                return itemOne.price - itemTwo.price;
            })
        };
        Store.prototype.filterItemsByName = function (partOfName) {
            var items = this._items;

            var sortedItems = [];
            for (var i = 0, len = items.length; i < len; i++) {
                var name = items[i].name.toLowerCase();
                var answer = name.indexOf(partOfName.toLowerCase());

                if (answer != -1) {
                    sortedItems.push(items[i]);
                }
            }
            return sortedItems;
        };

        Store.prototype.countItemsByType = function () {
            var associativeArray = {}; // {} will create an object

            var key = 'accessory';
            var val = getSortedItemsByType(this._items,key).length;
            associativeArray[key]  = val;

            key = 'smart-phone';
            val = getSortedItemsByType(this._items,key).length;
            associativeArray[key]  = val;

            key = 'notebook';
            val = getSortedItemsByType(this._items,key).length;
            associativeArray[key]  = val;

            key = 'pc';
            val = getSortedItemsByType(this._items,key).length;
            associativeArray[key]  = val;

            key = 'tablet';
            val = getSortedItemsByType(this._items,key).length;
            associativeArray[key]  = val;

            return associativeArray;
        };

        return Store;
    }());

    return Store;
});

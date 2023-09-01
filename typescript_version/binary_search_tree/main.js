var LinkedListNode = /** @class */ (function () {
    function LinkedListNode(val) {
        this.val = val;
        this.next = null;
    }
    return LinkedListNode;
}());
var LinkedList = /** @class */ (function () {
    function LinkedList() {
        this.head = null;
    }
    // Method to add new Node
    LinkedList.prototype.appendNewNode = function (val) {
        var newNode = new LinkedListNode(val);
        if (this.head === null) {
            this.head = newNode;
            return;
        }
        var current = this.head;
        while (current.next !== null) {
            current = current.next;
        }
        current.next = newNode;
    };
    return LinkedList;
}());
var linkedList = new LinkedList();
linkedList.appendNewNode("A");
linkedList.appendNewNode("B");
linkedList.appendNewNode("C");
linkedList.appendNewNode("D");
linkedList.appendNewNode("E");
linkedList.appendNewNode("F");
console.log(linkedList);

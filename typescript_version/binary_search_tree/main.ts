class LinkedListNode {
  public val:string;
  public next: LinkedListNode | null;
  constructor(val:string) {
    this.val = val;
    this.next = null;
  }
}

class LinkedList {
  public head:LinkedListNode | null;

  constructor() {
    this.head = null;
  }

  // Method to add new Node
  appendNewNode(val:string) {
    let newNode = new LinkedListNode(val);

    if(this.head === null) {
      this.head = newNode;
      return;
    }

    let current = this.head;
    while(current.next !== null) {
      current = current.next;
    }
    current.next = newNode;
  }
}
let linkedList = new LinkedList();
linkedList.appendNewNode("A");
linkedList.appendNewNode("B");
linkedList.appendNewNode("C");
linkedList.appendNewNode("D");
linkedList.appendNewNode("E");
linkedList.appendNewNode("F");
console.log(linkedList);

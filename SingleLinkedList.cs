
// class SingleLinkedList
// {
//     private Node? start;
//     private string EMPTY_LIST_MSG = "List is empty.";
//     public SingleLinkedList() 
//     {
//         start = null;
//     }

//     public void DisplayList(){
//         Node? node = start;
//         if(node != null){
//             while(node != null){
//                 Console.WriteLine(node.Value.ToString()+"->");
//                 node = node.Next;
//             }
//         } else Console.WriteLine(EMPTY_LIST_MSG);
//     }

//     public String Search(object searchValue){
//         if(start == null){ return EMPTY_LIST_MSG ; }
//         else
//         {
//             int index = 1;
//             Node? p = start;
//             while(p != null){
//                 if(p.Value == searchValue){
//                     return index.ToString();
//                 }
//                 p = p.Next;
//                 index++;    
//             }
//             return "Value not found in the list.";
//         }
//     }

//     public int CountNodes(){
//         if(start == null){ return 0;}
//         int count = 0;
//         Node p = start;
//         while(p != null){
//             count++;
//             p = p.Next;
//         }
//         return count;
//     }

//     public Node FetchLastNode(){
//         Node? p = start;
//         while(p.Next != null){
//             p = p.Next;
//         } 
//         return p;
//     }

//     public Node FindNode(object value){
//         Node? p = start;
//         while(p!= null){
//             if(p.Value == value) break;
//             p = p.Next;
//         }
//         return p;
//     }

//     public void InsertAtTheStart(object value){
//         Node temp = new Node(value);
//         if(start != null) temp.Next = start;
//         start = temp;
//     }

//     public void InsertAtTheEnd(object value){
//         Node temp = new Node(value);
//         Node? p = start;
//         if(start != null){
//             if(p.Next != null){
//             p = p.Next;
//             }
//         }
//         p.Next = temp;
//     }

//     public void InsertAfterIndex(object value, int index){
//         Node temp = new Node(value);
//         Node? p = start;
//         for(int i = 0;i < index && p.Next != null;i++){
//             p = p.Next;
//         }
//         temp.Next = p.Next;
//         p.Next = temp;
//     }

//     public void InsertAtIndex(object value, int index){
//         if(index == 1) { InsertAtTheStart(value); }
//         else {
//             Node temp = new Node(value);
//             Node? p = start;
//             for (int i = 0; i < index - 1 ; i++){
//                 p = p.Next;
//             }
//             temp.Next = p.Next;
//             p.Next = temp;
//         }
        
//     }
// }
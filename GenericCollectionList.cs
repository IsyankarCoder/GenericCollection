using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace GenericCollectionList{
    public class GenericCollection<T>
        : System.Collections.Generic.IEnumerable<T>
    {
      
       List<T> genericList=new  List<T>();

       public GenericCollection(){

       }


       
       public IEnumerable<T> FilterList(IEnumerable<T> source,Func<T,string,bool> predicateFilter,string filters){
           List<T> innerList = new List<T>();
           foreach(T item in source){
               if(predicateFilter(item,filters)){
                innerList.Add(item); //Burada  yield da kullanabiliruk....
               }
           }
           return innerList;
       }

       ///
       ///  indexleyici bulunmak
       ///  genericList[0] şeklinde değer dönmekte yada set edilebilmekte.
       public T this[int index]{
           get{return genericList[index];}
           set{genericList[index]=value;}
       }
      
       public void Add(T item){
           genericList.Add(item);
       }
      
      
      
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
           return genericList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return genericList.GetEnumerator();
        }
    }
}
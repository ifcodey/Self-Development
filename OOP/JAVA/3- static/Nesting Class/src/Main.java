public class Main {
    public static void main(String[] args) {
        OuterClass.InnerClass obj = new OuterClass.InnerClass();
//        because x is not static variable we can just create obj to access to it without put it static.
         obj.print();
    }
}
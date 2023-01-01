public class OuterClass {
//    can use static for inner class only not for OuterClass.
    static int x = 10;
    public static class InnerClass{
    public void print(){
        System.out.println("X = " + x);
    }
    }
}

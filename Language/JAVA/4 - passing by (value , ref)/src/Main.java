public class Main {
    static void passingByValue(int n) {
        n++;
    }

    static void passingByRef(Test n) {
        n.number++;
    }

    public static void main(String[] args) {
//        passingByValue
        int number = 1;
        passingByValue(number);
        System.out.println("Number (passing by value) = " + number);

//        passingByReference
//        the only way to passing by ref in java by used obj.
        Test obj = new Test();
        obj.number = 1;
        passingByRef(obj);
        System.out.println("Number (passing by reference) = " + obj.number);
    }
}
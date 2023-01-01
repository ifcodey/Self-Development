
public class Main {
    static int add(int n1, int n2) {
        int num = n1 + n2;
        return num;
    }

    public static void main(String[] args) {

//        ----------------how to add to variable----------------
        int result = add(2, 5);
//        System.out.println("the result is : " + result);

//        ----------------how to add to object----------------
        Math ob1 = new Math(2);
        Math ob2 = new Math(5);
        Math ob11 = new Math(5);
//        Math ob3 = ob1 + ob2 -> in other language.
        Math caller = new Math();

        Math ob3 = caller.add(ob1, ob2);
        System.out.println("ob3 is :" + ob3.val);

//        ----------------compare two object----------------
        if (ob1 == ob2) {
            System.out.println("Equal");
        } else {
            System.out.println("Not Equal");
        }

        ob1 = ob2;
        System.out.printf("OB2 = %s  \n", ob2.val);
        System.out.printf("OB1  = %s \n", ob1.val);

        if (ob1 == ob2) {
            System.out.println("Equal");
        } else {
            System.out.println("Not Equal");
        }
    }
}
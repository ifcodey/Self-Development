 public class Student {
    final int STUDENT_ID;
    String name;
    int yearOfBirth;
    //    final float DEGREE_OF_SUCESS = 50;
    static float DEGREE_OF_SUCESS;

    //    there is specific block for static --> to pass a value to variable.
    static {
        DEGREE_OF_SUCESS = 50;
    }

    {
        System.out.println("Student Block");
        STUDENT_ID = 55;
    }

    public Student(int STUDENT_ID, String name, int yearOfBirth) {
//        can use it but delete a student block.
//        this.STUDENT_ID = STUDENT_ID;
        this.name = name;
        this.yearOfBirth = yearOfBirth;
    }

    public Student() {
    }

    @Override
    final public String toString() {
        return "Student{" +
                "STUDENT_ID=" + STUDENT_ID +
                ", name='" + name + '\'' +
                ", yearOfBirth=" + yearOfBirth +
                '}';
    }
}
// final if used before class will prevent inheritance.
class GraduatedStudent extends Student {
//    if I want to prevent override , I just used final keyword.

//    ERROR >>

/*
    @Override
    public String toString() {
        return "Student{" +
                "STUDENT_ID=" + STUDENT_ID +
                ", name='" + name + '\'' +
                ", yearOfBirth=" + yearOfBirth +
                '}';
    }
*/

}

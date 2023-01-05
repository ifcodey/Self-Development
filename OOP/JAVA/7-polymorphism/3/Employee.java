import java.util.*;

public class Employee {
    private String name, address, department, email, phone;
    private float salary;

    public Employee(String name, String email, String phone, String department, String address, int salary) {
        this.name = name;
        this.email = email;
        this.phone = phone;
        this.department = department;
        this.address = address;
        this.salary = salary;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getAddress() {
        return address;
    }

    public void setAddress(String address) {
        this.address = address;
    }

    public String getDepartment() {
        return department;
    }

    public void setDepartment(String department) {
        this.department = department;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public String getPhone() {
        return phone;
    }

    public void setPhone(String phone) {
        this.phone = phone;
    }

    public float getSalary() {
        return salary;
    }

    public void setSalary(float salary) {
        this.salary = salary;
    }

    public static void printWithStatic() {
        System.out.println("base-Class");
    }

    public void printWithoutStatic() {
        System.out.println("base-Class");
    }
}

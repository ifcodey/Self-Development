public class Math {
    int val;

    public Math() {
    }

    public Math(int val) {
        this.val = val;
    }

    Math add(Math n1, Math n2) {
        Math num = new Math();
        num.val = n1.val + n2.val;
        return num;
    }
}

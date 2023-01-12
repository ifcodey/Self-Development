

import java.util.ArrayList;
import java.util.Arrays;
import java.util.*;

public class ArrayTest1 extends ArrayList {
    public void doing() {
        ArrayList<Integer> list1 = new ArrayList<>();
        list1.add(5); //0
        list1.add(6); //1
        list1.add(10); //2
//        replace value.
        list1.set(2, 11);
        list1.add(20);
//        remove
        list1.remove(1);
        list1.add(30);
//        remove obj value
        System.out.println("Remove obj " + list1.remove(new Integer(5)));
        System.out.println("Remove obj " + list1.remove(Integer.valueOf(6)));
        ArrayList<Integer> list2 = new ArrayList<>();
        list2.addAll(list1);
        list2.add(40);
        list2.add(50);

//        Arrays.asList -> at a item as one list -> like add list to other.
        list2.addAll(Arrays.asList(66, 88, 99));
//        or get object of list1 and convert it -> called shallow copy -> have instance from another array.
//        list2 = (ArrayList) list1.clone();

        for (int i = 0; i < list2.size(); i++) {
            System.out.println(list2.get(i));
        }
    }

    public void doing1() {
//       used Arraylist Copy Constructor  when add to array ->> Arrays.asList(10, 20, 30)
        ArrayList<Integer> list1 = new ArrayList<>(Arrays.asList(10, 20, 30));
        ArrayList<Integer> list2 = new ArrayList<>();
//        reference copy -> list2 = list1 -> when change any array will change on other -> two array have same address in memory.
        list2 = list1;
        System.out.println(list2);

        for (int i = 0; i < list2.size(); i++) {
            System.out.println(list2.get(i));
        }
    }

    public void doing2() {

        ArrayList<String> list1 = new ArrayList(Arrays.asList("A", "B", "C", "E", "A", "F", "G"));
        ArrayList<Integer> list2 = new ArrayList(Arrays.asList(10, 20, 30, 40, 50));
//        Remove all A in arrayList.
        System.out.println(list1.removeAll(Arrays.asList("A")));
//        or
        System.out.println(list1.removeAll(Collections.singleton("B")));
        System.out.println(list1);
//        or
        list2.removeIf(num -> num % 2 == 0);
        System.out.println(list2);

    }

    public void doing3() {
        ArrayList<String> list1 = new ArrayList(Arrays.asList("A", "B", "C", "E", "A", "F", "G"));
        ArrayTest1 arr = new ArrayTest1();

        arr.add(10);
        arr.add(20);
        arr.add(30);
        arr.add(40);

//        removeRange need inheritance from ArrayList class.
        arr.removeRange(0, 1);


        System.out.println(arr);


    }

    public void doing4() {
        Object[] arr = new Object[5];
        arr[0] = "AA";
        arr[1] = 'c';
        arr[2] = true;
        arr[3] = 10;

//        System.out.println(arr);

        for (Object n : arr) {
            System.out.println(n);
        }

    }

    public void doing5() {
        ArrayList<Integer> list = new ArrayList<>(Arrays.asList(10, 20, 30, 40));
        System.out.println(list.contains(10));
    }

    public void doing6() {
        ArrayList<Integer> list1 = new ArrayList<>(Arrays.asList(1, 2));
        ArrayList<Integer> list2 = new ArrayList<>(Arrays.asList(1, 1, 1, 1, 2, 2, 3, 4, 5, 6, 7, 8, 9, 10));
//        print a match element and save it in list2.
        list2.retainAll(list1);
//        or
//        list2.retainAll(Arrays.asList(10));
//        or
//        list2.removeAll(Collections.singleton(1));

        System.out.println(list2);
    }

    public void doing7() {
        ArrayList list1 = new ArrayList<>(Arrays.asList(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));
        ArrayList list2 = new ArrayList(list1.subList(0, 3));
        System.out.println(list2);
    }

    public void doing8() {
        ArrayList list1 = new ArrayList<>(Arrays.asList(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));
        System.out.println(list1.isEmpty());
        list1.clear();
        System.out.println(list1);
    }

    public void doing9() {
        ArrayList list1 = new ArrayList<>(200);
        list1.ensureCapacity(150);
    }

    public void doing10() {
        ArrayList list1 = new ArrayList<>(Arrays.asList(10, 20, 30, 40, 25, 35, 403, 65, 12));
        ArrayList list2 = new ArrayList<>(Arrays.asList(10, 20, 30, 40, 25, 35, 403, 65, 12));
        ArrayList list3 = new ArrayList<>(Arrays.asList(10, 20, 30, 40, 25, 35, 403, 65, 12));

//        sort the element.
        Collections.sort(list1);
        System.out.println(list1);

//        reverse sort.
        Collections.sort(list2, Collections.reverseOrder());
        System.out.println(list2);

//        reverse position of element.
        Collections.reverse(list3);
        System.out.println(list3);

//        get min/max value from ArrayList.
        System.out.println("The Min in List 1 is :" + Collections.min(list1));
        System.out.println("The Max in List 1 is :" + Collections.max(list1));
    }

    public void doing11() {
        ArrayList list = new ArrayList<>();
        Scanner in = new Scanner(System.in);

        for (int i = 0; i < 5; i++) {
            int temp = in.nextInt();
            if (!list.contains(temp)) {
                list.add(temp);
            }
        }
        System.out.println(list);
    }
}


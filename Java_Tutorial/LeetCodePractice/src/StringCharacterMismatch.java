public class StringCharacterMismatch {

    public static void main(String[] args) {
        System.out.println(strStr("iiisadiouisad","uijjj"));
    }
    public static int strStr(String haystack, String needle) {
        int i=0;
        int j = needle.length();
        while(i<haystack.length())
        {

                if(haystack.substring(i,i+j).equals(needle))
                {

                    return i;
                }

            i++;

        }

        return -1;
    }



}

public class Solution {
    public int[] Decrypt(int[] code, int k) {
        int arrLength = code.Length;
        int i;
        int j;
        int[] endCode = new int[arrLength];
        for (i = 0; i<arrLength; i++){
            endCode[i] = code[i];
        }
        int index;
        int sum;
        
        if (k == 0){        // for when k is 0, all vals in code are set to 0
            for(i = 0; i < arrLength; i++){
                endCode[i] = 0;
            }
        }
        else if(k > 0){     // for when k is positive, sum = next k terms, loop
            for(i = 0; i < arrLength; i++){
                sum = 0;
                for(j = 1; j <= k;j++){    //will add all of the values after k into sum
                    if(arrLength <= i+j){        //checks for existing past the arr
                        index = i+j-arrLength;
                    }
                    else{
                        index = i+j;
                    }
                    //at this point, we need to add code[index] into sum
                    sum += code[index];
                }
                //we now have the sum of the next k values within code
                endCode[i] = sum;
            }
        }
        else if(k < 0){     // for when k is negative, sum = prev k terms, loop
            for(i = 0; i < arrLength; i++){             
                sum = 0;
                for(j = -1; j >= k;j--){    //will add all of the values after k into sum
                    if(0 > i+j){        //checks for existing past the arr
                        index = i+j+arrLength;
                    }
                    else{
                        index = i+j;
                    }
                    //at this point, we need to add code[index] into sum
                    sum += code[index];
                }
                //we now have the sum of the next k values within code
                endCode[i] = sum;  
            }
        }
        return endCode;     
    }
}
class Solution
{
public:
    vector<int> decrypt(vector<int>& code, int k)
    {
        vector<int> code2;
        for (int count = 0; count < 3; count++)
        {
            for (int count2 = 0; count2 < code.size(); count2++)
            {
                code2.push_back(code[count2]);
            }
        }
        vector<int> decrypted;
        int counter = 0;
        if (k > 0)
        {
            while (counter < code.size())
            {
                int number = 0;
                for (int counter2 = 1; counter2 <= k; counter2++)
                {
                    number += code2[counter2 + counter];
                }
                decrypted.push_back(number);
                counter++;
            }
        }
        else if (k < 0)
        {
            counter = code.size();
            while (counter < code.size() * 2)
            {
                int number = 0;
                for (int counter2 = -1; counter2 >= k; counter2--)
                {
                    number += code2[counter + counter2];
                }
                decrypted.push_back(number);
                counter++;
            }
        }
        else
        {
            for (int counter = 0; counter < code.size(); counter++)
            {
                decrypted.push_back(0);
            }
        }
        return decrypted;
    }
};

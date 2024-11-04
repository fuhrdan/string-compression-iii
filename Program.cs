//*****************************************************************************
//** 3163. String Compression III    leetcode                                **
//*****************************************************************************

char* compressedString(char* word) {
    int n = strlen(word);
    char* comp = (char*)malloc(n * 2 + 1);  // Allocating max possible size
    int compIndex = 0;
    int i = 0;

    while (i < n) {
        char c = word[i];
        int count = 0;

        while (i < n && word[i] == c && count < 9) {  // Limit count to 9
            count++;
            i++;
        }

        // Add count to comp
        compIndex += sprintf(comp + compIndex, "%d", count);

        // Add character to comp
        comp[compIndex++] = c;
    }

    // Null-terminate the compressed string
    comp[compIndex] = '\0';

    return comp;
}
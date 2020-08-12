# Logic Matrix
(This is an experiment.)

Addeed lambda function to matrix class for each element (Normally, a matrix contains only value for each element).

```
// Define lambda
Func<float, float> some_lambda_function = x => {
    if (x > 10) {
        return 1;
    } else {
        return 0;
    }
}

// Matrix Element returns,
retun some_lambda_function(m[i][j]);
```

I consider to use this modified matrix for computing Machine Learning and Least Square.

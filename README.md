```
BEGIN
	CLASS Program
		Main METHOD
    			VAR num = CONVERT TO INT (PROMPT USER("enter a number:"))
    			VAR sum = 0;
    			VAR i = num - 1, while i > 0, decrement i 
      				IF num is divisible by i THEN 
        				sum += i;
      				
    			
    			if sum equals num THEN 
      				PRINT
				 - "Perfect Number"
    			ELSE 
				PRINT
				 - "Not A Perfect Number"
    			
		END Main
	END Program
END
```

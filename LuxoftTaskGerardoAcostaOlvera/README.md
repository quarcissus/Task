# ReturnChange correct execution.
Instructions to correctly execute the function.

## Setting Variables.

Before running the function validate that the file Utility.cs contains the following information:  

###  CURRENCYCODES Class 
- Add the CURRENCYCODE of the new/current country.  
public const string {NewCountry} = "NewCountryCurrencyCode";  


### CURRENCYDENOMINATIONS Class
- Add the CURRENCYDENOMINATIONS of the new/current country.  
public static readonly decimal[] {NewCountry} = { all the denominations of the new/current country };  

### COUNTRYGLOBALDATA Class  
- Edit the COUNTRYGLOBALDATA attributes.  
public const string CURRENCYCODE = CURRENCYCODES.{NewCountry};  
public static readonly decimal[] DENOMINATION = CURRENCYDENOMINATIONS.{NewCountry};  


## Function now can be executed correctly!.  

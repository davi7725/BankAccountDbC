# Bank Account (Design by Contract) Application
This application contains an [Account](https://github.com/davi7725/BankAccountDbC/blob/master/BankAccountDbC/Account.cs) class that implements:
- `Deposit(double amount)` - increases the account’s balance with the amount;
  - **Rules:**
    - the amount should always be positive
- `Withdraw(double amount)` - decreases the account’s balance;
  - **Rules:**
    - the amount should always be positive
    - if the amount **exceeds** the balance: 
      - the balance should be left untouched 
      - an exception should be thrown.
- Instantiating a new Account class
  - **Rules:**
    - the start amount should always be positive
    - the name of the account should not be empty

Additionally, [Program class](https://github.com/davi7725/BankAccountDbC/blob/master/BankAccountDbC/Program.cs) makes use of **Account.cs** and it also demonstrates the use of Code Contracts that enforce Design by Contract principles.

</br>

---
## Setting up

To be able to observe the defined **Design by Contract principles** you would need to install [*Visual studio 2015*](https://stackoverflow.com/questions/44290672/how-to-download-visual-studio-community-edition-2015-not-2017) <img height="20" src="https://user-images.githubusercontent.com/21998037/67194787-1322d680-f3f8-11e9-9ed1-c432468f1555.png">.

As well as installing [*Code Contracts for .NET*](https://marketplace.visualstudio.com/items?itemName=RiSEResearchinSoftwareEngineering.CodeContractsforNET).

Once you are done with the above, in VS you would need to:

- Go to **Project** > **Properties** > **Code Contracts**
  - tick **Perform Static Contract Checking**
  - untick **Cache results** 
  - set **Warning Level** to high 
  - **Save**

- By **Build**ing - incorrect param values should get squiggly lines

- Into **Task List** window you would be able to see the warnings that were generated
  
<h4 align="center">As shown in the picture below:</h4>
<p align="center">
<img height="500" src="https://user-images.githubusercontent.com/21998037/67195330-0ce12a00-f3f9-11e9-8a5c-a6a768472a20.png">
</p>

</br>

---
## Example

> Not obeying the *positive amount* rule when setting up a new Account
<img height="250" src="https://user-images.githubusercontent.com/21998037/67195961-3e0e2a00-f3fa-11e9-8059-db596d3dc5b7.png">

Having this line of code will give us the **Warning** :warning: that the amount we provide when setting up an account should have a positive value. </br>
As well as:
<img src="https://user-images.githubusercontent.com/21998037/67196320-dc01f480-f3fa-11e9-98c0-4f4d61fe7be7.png">

</br>

> Not obeying the *positive amount* rule when Depositing
<img height="250" src="https://user-images.githubusercontent.com/21998037/67196472-2b482500-f3fb-11e9-99ce-3839c10227cd.png">

</br>

The **DbC** rules we used can be seen :eyes: in the [Account.cs](https://github.com/davi7725/BankAccountDbC/blob/master/BankAccountDbC/Account.cs) class.

</br>

___
> #### Assignment made by:   
`David Alves 👨🏻‍💻 ` :octocat: [Github](https://github.com/davi7725) <br />
`Elitsa Marinovska 👩🏻‍💻 ` :octocat: [Github](https://github.com/elit0451) <br />
> Attending "Discrete Mathematics" course of Software Development bachelor's degree

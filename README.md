# DataKey
I'm working on a security system that aims to little companies that can't afford Systems like fingerprint, face recognition, etc.
It works with a Random Generated KeyPass and a SQL Server DataBase. When a Master or a Guard is sure about the information provided for the employee and confirm that the employee is part of the DataBase. 
They can generate an employee KeyPass for entering the system.

## Versioning Scheme
S-W.Z.Y.X
- S - A release name
- W - Big changes that affect the entire structure or roadmap of the application.
- Y - Big changes that add significantly more features to the application. Releases will usually be made upon a change to this number
- Z - Small changes that add or remove features, and usually scale up to a change to Y
- X - Minor changes that usually include patches or even minor spelling fixes

## Installation

- Be sure to install the next Packages (Changes will be apply if required):

```bash
- System.Data.SqlClient
- Visual Basic PowerPacks
```
- Be sure to change the SQL Server Data Base direction on DataAccess/ConnectionToSql.cs to your own SQL Server direction. (You can do this by changing the "server" and "DataBase" strings.)
- Be sure to change the part of code in DataAccess/UserDao, to your own table name.
- Finally maintain the same template of tables. It is provided on Table.txt

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

## License
[MIT](https://choosealicense.com/licenses/mit/)

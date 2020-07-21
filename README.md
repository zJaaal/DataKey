# DataKey
This is my first project. I'm working on a security system that aims to little companies that can't afford Systems like fingerprint, face recognition, etc.
It works with a Random Generated KeyPass and a SQL Server DataBase. When a Master or a Guard is sure about your information and confirm that you are part of the DataBase. 
Them can generate your own KeyPass for entering the system.

## Versioning Scheme
S-W.Z.Y.X
- S - A release name
- W - Big changes that affect the entire structure or roadmap of the application.
- Y - Big changes that add significantly more features to the application. Releases will usually be made upon a change to this number
- Z - Small changes that add or remove features, and usually scale up to a change to Y
- X - Minor changes that usually include patches or even minor spelling fixes

## Installation

- Be sure to install the next NuGet Extensions (Changes will be apply if required):

```bash
- System.Data.SqlClient
```
- Be sure to change the SQL Server Data Base direction on DataAccess/ConnectionToSql.cs to your own SQL Server direction. (You can do this by changing the "server" and "DataBase" strings.)
- Be sure to maintain the same template of tables. It is provided on Table.txt

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

## License
[MIT](https://choosealicense.com/licenses/mit/)

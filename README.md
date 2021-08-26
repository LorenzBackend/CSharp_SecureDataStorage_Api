# CSharpSecureDataStorageApi
store your C#.Net or unity user data securely and encrypted on the computer. i have built an api that makes it easier for you than ever before 

## here is a little guide for you
```csharp
using SecureDataStorage; // Dont forget the using ;)
```

Create a instance of the Class
```csharp
StorageData storage = new StorageData("YOUR_APP_NAME"); 
```

Storage Data
```csharp
storage.SetString("MyString", "MySafeStringValue");
```

Get Storage Data
```csharp
string sString = storage.GetString("MyString"); // sString has the value "MySafeStringValue"
```

Get Storage Data
```csharp
string version = storage.GetApiVersion(); // returns the version of my Api
```

Storage Data Commands
```csharp
// Set Storage
storage.SetInt("MyInt", 0);
storage.SetFloat("MyInt", 0);
storage.SetBool("myBool", true);
storage.SetFloat("MyFloat", 1.2f);


//GetStorage
storage.GetInt("MyInt");
storage.GetFloat("MyInt");
storage.GetBool("myBool");
storage.GetFloat("MyFloat");
```


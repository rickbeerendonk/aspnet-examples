# Secret Manager: dotnet commands

## Step 1 - Init

Secret Manager

```zsh
dotnet user-secrets init
```

Command creates `<UserSecretsId>e0448e08-f94f-42e0-bfb4-adaee8a3190d</UserSecretsId>` in the .csproj file.

## Step 2 - Set

In the project folder, run:

```zsh
dotnet user-secrets set <name-of-secret> <value-of-secret>
```

Creates a folder will be created with the GUID as a name. The GUID folder will contain an unencrypted file called `secrets.json`.

In this file the `name-of-secret` and `value-of-secret` will be stored:

```json
{
  "name-of-secret": "value-of-secret"
}
```

### Windows

GUID-named folder will be in the roaming AppData folder (%AppData%, typically resolves to `C:\Users\<user-name>\AppData\Roaming`) and in the `Microsoft\UserSecrets` subfolder.

### macOS and Linux

the path will be `~/.microsoft/usersecrets/<GUID>` (the tilde character points to the user's home folder).

## Licence

European Union Public Licence version 1.2

## Copyright

Copyright © 2024 Rick Beerendonk

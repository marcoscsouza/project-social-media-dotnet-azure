# migrations


#### migrations dos models direto no mvc
dotnet ef migrations add addInitial --startup-project SpotMusic --project SpotMusic --context SpotMusicDBContext --output-dir Data\Migrations

dotnet ef database update --startup-project SpotMusic --project SpotMusic --context SpotMusicDBContext


#### migrations do identity direto no mvc
dotnet ef migrations add addIdentity --startup-project SpotMusic --project SpotMusic --context IdentityDBContext --output-dir Areas\IdentityData\Migrations

dotnet ef database update --startup-project SpotMusic --project SpotMusic --context IdentityDBContext


dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
cp ../../../openapi.yaml openapi.yaml

autosdk generate openapi.yaml \
  --namespace Sonauto \
  --clientClassName SonautoClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer

rm -rf ../../cli/Sonauto.CLI

autosdk cli-project openapi.yaml \
  --output ../../cli/Sonauto.CLI \
  --sdk-project ../../libs/Sonauto/Sonauto.csproj \
  --targetFramework net10.0 \
  --namespace Sonauto \
  --clientClassName SonautoClient \
  --package-id Sonauto.CLI \
  --tool-command-name sonauto \
  --user-secrets-id Sonauto.CLI \
  --api-key-env-var SONAUTO_API_KEY \
  --base-url-env-var SONAUTO_BASE_URL \
  --cli-credential-file \
  --cli-keep-api-group \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer

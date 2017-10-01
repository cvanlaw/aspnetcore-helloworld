param(
    [switch]$Rebuild,
    [switch]$UseCache
)

$dockerFile = "./docker/dev/Dockerfile";
$dockerBuildCommand = "docker build -t aspnetcore-helloworld -f $dockerFile ." ;

if(!$UseCache) {
    $dockerBuildCommand += " --no-cache"
}

if($Rebuild) {
    Invoke-Expression $dockerBuildCommand
}

$dockerRunCommand = "docker run -d -p 8080:80 aspnetcore-helloworld"
Invoke-Expression $dockerRunCommand

Invoke-Expression "docker ps"
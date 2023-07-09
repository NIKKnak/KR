## Task 1
mkdir KR    
cat > home_animals    
cat > home_animals2    
cat home_animals home_animals2 > mans_friends   
ls

## Task 2 
mkdir CopDir      
mv KR/mans_friends CopDir/    


## Task 3
sudo wget https://dev.mysql.com/get/mysql-apt-config_0.8.23-1_all.deb    
sudo dpkg -i mysql-apt-config_0.8.23-1_all.deb    
sudo apt update    
sudo apt install mysql-server    

## Task 4
sudo wget https://download.docker.com/linux/ubuntu/dists/jammy/pool/stable/amd64/docker-ce-cli_20.10.13~3-0~ubuntu-jammy_amd64.deb    
sudo dpkg -i docker-ce-cli_20.10.13~3-0~ubuntu-jammy_amd64.deb    
sudo dpkg -r docker-ce-cli_20    
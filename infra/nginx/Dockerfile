FROM nginx

# ARG productionUrl  
# ENV env_productionUrl=$productionUrl
# ARG mirrorUrl  
# ENV env_mirrorUrl=$mirrorUrl

COPY nginx-mirror.conf /etc/nginx/nginx.conf
# RUN find /etc/nginx/nginx.conf -type f -exec sed -i 's/productionUrl/'$env_productionUrl'/g' {} \;
# RUN find /etc/nginx/nginx.conf -type f -exec sed -i 's/mirrorUrl/'$mirrorUrl'/g' {} \;
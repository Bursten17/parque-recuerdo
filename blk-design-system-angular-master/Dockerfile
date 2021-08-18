FROM node as node

WORKDIR /app
COPY ./ /app
RUN npm install
RUN npm run build -- --prod

FROM nginx
COPY --from=node /app/dist/blk-design-system-angular /usr/share/nginx/html

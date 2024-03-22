FROM node:21-alpine

WORKDIR /cutedogweb
COPY package.json .
COPY src/ ./src
COPY public/ ./public
COPY index.html .



RUN npm install

CMD ["npm", "start"]
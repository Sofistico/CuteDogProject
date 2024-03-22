FROM node:21-alpine
EXPOSE 5173
EXPOSE 5174

WORKDIR /cutedogweb
COPY package.json .
COPY src/ ./src
COPY public/ ./public
COPY index.html .



RUN npm install

CMD ["npm", "start"]
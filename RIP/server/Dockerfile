FROM node:12-slim
WORKDIR /dock
COPY package.json /dock
RUN npm install
COPY . /dock
CMD ["npm", "start"]
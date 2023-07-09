import { configureStore } from '@reduxjs/toolkit'
import React from 'react'
import listreducer from './listslice';

const liststore = configureStore({
    reducer :{
        list:listreducer,
    },
});

export default liststore
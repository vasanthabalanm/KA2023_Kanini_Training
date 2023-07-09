import React from 'react'
import { configureStore } from '@reduxjs/toolkit';
import CounterReducer from './reducer'

    const store = configureStore({
        reducer:{
            counter:CounterReducer,
        },
    });

export default store
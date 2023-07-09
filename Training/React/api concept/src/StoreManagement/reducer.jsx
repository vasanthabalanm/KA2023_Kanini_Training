// counterslice
import { createSlice } from "@reduxjs/toolkit";

import React from 'react'

const reducer = createSlice ({
    name:'counter',
    initialState:0,
    reducers:{
        increment:(state)=>state + 1, 
        decrement:(state)=>state - 1,
    },
});

export const {increment,decrement} = reducer;
export default reducer.reducer;
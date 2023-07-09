import { createSlice } from '@reduxjs/toolkit'
import React from 'react'

const listslice =  createSlice({
    name:'list',
    initialState:[],
    reducers:{
        addList:(state,action)=>{
            state.push(action.payload);

        },
        remoList:(state,action)=>{
            return state.filter((list)=>list.id !== action.payload);
        },
    },
});

export default listslice.reducer;
export const {addList, remoList} = listslice.actions;

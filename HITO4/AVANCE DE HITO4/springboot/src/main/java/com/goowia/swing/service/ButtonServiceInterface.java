package com.goowia.swing.service;

import com.goowia.swing.model.ButtonModel;

import java.util.List;

public interface ButtonServiceInterface {
    public void saveData();
    public String getRow();
    public List<ButtonModel> getAllTitleButton();
}

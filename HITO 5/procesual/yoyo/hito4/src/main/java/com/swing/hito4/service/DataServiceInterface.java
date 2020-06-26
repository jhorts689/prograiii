package com.swing.hito4.service;

import com.swing.hito4.model.Datamodel;

import java.util.List;

public interface DataServiceInterface {

    public void saveData();
    public List<Datamodel> getAllLettersFirst();
    public List<Datamodel> getAllLettersSecond();
    public List<Datamodel> getAllLettersThree();
}

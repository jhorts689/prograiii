package com.goowia.swing.service;

import com.goowia.swing.model.ButtonModel;
import com.goowia.swing.repository.ButtonRepo;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.ArrayList;
import java.util.List;

@Service
public class ButtonService implements ButtonServiceInterface {
    private static final String TITLE_BUTTONS = "SAVE DELETE CANCEL LOGIN LOGOUT UPDATE";
    @Autowired
    private ButtonRepo buttonRepo;

    @Override
    public void saveData() {
        if (buttonRepo.count() == 0) {
            String[] titleButtons = TITLE_BUTTONS.split(" ");

            for(String title : titleButtons){
                buttonRepo.save(new ButtonModel(title));
            }
        }
    }

    @Override
    public String getRow() {
        ButtonModel bModel = buttonRepo.getTitleButton();
        return bModel.getTitleButton();
    }

    @Override
    public List<ButtonModel> getAllTitleButton() {
        //List<ButtonModel> allTitles = new ArrayList<ButtonModel>();
        //buttonRepo.findAll().forEach(allTitles::add);
        //return allTitles;
        return new ArrayList<ButtonModel>(buttonRepo.findAll());
    }
}

package com.swing.hito4.Gui.Panels;

import com.swing.hito4.Gui.listener.ButtonListener;
import com.swing.hito4.Gui.util.Util;
import com.swing.hito4.model.Datamodel;
import com.swing.hito4.service.DataService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Component;

import javax.annotation.PostConstruct;
import javax.swing.*;
import java.awt.*;
import java.util.List;
@Component
public class DataPanel extends JPanel {
    @Autowired
    private DataService dataService;


    public DataPanel(){
        System.setProperty("butBackColor", "#C1ECF1");
        System.setProperty("textColor", "#0B0BF6");
        this.setPreferredSize(new Dimension(600, 190));
        this.setBackground(Color.blue);
        this.setLayout(new GridLayout(3, 0));
    }
    @PostConstruct
    public void createButtonsLetters(){
        java.util.List<Datamodel> firstRow = dataService.getAllLettersFirst();
        String[] titleData = firstRow.get(0).getLetter().split(",");
        JPanel panelQ_P = this.createPanelButton(titleData);
        this.add(panelQ_P);

        java.util.List<Datamodel> secondRow = dataService.getAllLettersSecond();
        String[] titleData1 = secondRow.get(0).getLetter().split(",");
        JPanel panelA_L = this.createPanelButton(titleData1);
        this.add(panelA_L);

        List<Datamodel> threeRow = dataService.getAllLettersThree();
        String[] titleData2 = threeRow.get(0).getLetter().split(",");
        JPanel panelZ_M = this.createPanelButton(titleData2);
        this.add(panelZ_M);
    }

    public JPanel createPanelButton(String[] titleAlphabet) {
        JPanel mainPanel = new JPanel();
        mainPanel.setLayout(new FlowLayout());
        ButtonListener listener = new ButtonListener();

        for (String title : titleAlphabet) {
            JButton button = new JButton(title);
            button.setPreferredSize(new Dimension(55, 40));
            button.addActionListener(listener);
            button.setBackground(Color.getColor("butBackColor"));
            button.setForeground(Color.getColor("textColor"));
            button.setBorder(BorderFactory.createEmptyBorder());
            button.setFont(Util.FONT_TEXT);
            mainPanel.add(button);
        }

        return mainPanel;
    }
}

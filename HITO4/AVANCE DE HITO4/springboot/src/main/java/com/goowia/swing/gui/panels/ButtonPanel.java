package com.goowia.swing.gui.panels;

import com.goowia.swing.model.ButtonModel;
import com.goowia.swing.service.ButtonService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Component;

import javax.annotation.PostConstruct;
import javax.swing.*;
import java.awt.*;
import java.util.List;

@Component
public class ButtonPanel extends JPanel {
    @Autowired
    private ButtonService buttonService;

    public ButtonPanel() {
        this.setPreferredSize(new Dimension(600, 400));
        this.setBackground(Color.blue);
        this.setLayout(new GridLayout(3, 0));
    }

    @PostConstruct
    public void createButtons() {
        JPanel mainPanel = new JPanel();
        mainPanel.setLayout(new FlowLayout());

        List<ButtonModel> allTitles = buttonService.getAllTitleButton();

        allTitles.forEach(buttonModel -> {
            JButton button = new JButton(buttonModel.getTitleButton());
            button.setPreferredSize(new Dimension(100, 40));
            mainPanel.add(button);
        });

        this.add(mainPanel);
    }
}

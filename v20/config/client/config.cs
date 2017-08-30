// Torque Input Map File
moveMap.delete();
new ActionMap(moveMap);
moveMap.bindCmd(keyboard, "escape", "", "escapeMenu.toggle();");
moveMap.bind(keyboard, "w", moveForward);
moveMap.bind(keyboard, "s", movebackward);
moveMap.bind(keyboard, "a", moveleft);
moveMap.bind(keyboard, "d", moveright);
moveMap.bind(keyboard, "space", Jump);
moveMap.bind(keyboard, "lshift", Crouch);
moveMap.bind(keyboard, "c", Walk);
moveMap.bind(keyboard, "f", toggleZoom);
moveMap.bind(keyboard, "z", toggleFreeLook);
moveMap.bind(keyboard, "tab", toggleFirstPerson);
moveMap.bind(keyboard, "f8", dropCameraAtPlayer);
moveMap.bind(keyboard, "f7", dropPlayerAtCamera);
moveMap.bind(keyboard, "t", GlobalChat);
moveMap.bind(keyboard, "y", TeamChat);
moveMap.bind(keyboard, "pageup", PageUpNewChatHud);
moveMap.bind(keyboard, "pagedown", PageDownNewChatHud);
moveMap.bind(keyboard, "m", ToggleCursor);
moveMap.bind(keyboard, "1", useBricks);
moveMap.bind(keyboard, "q", useTools);
moveMap.bind(keyboard, "e", useSprayCan);
moveMap.bind(keyboard, "ctrl w", dropTool);
moveMap.bind(keyboard, "2", useSecondSlot);
moveMap.bind(keyboard, "3", useThirdSlot);
moveMap.bind(keyboard, "4", useFourthSlot);
moveMap.bind(keyboard, "5", useFifthSlot);
moveMap.bind(keyboard, "6", useSixthSlot);
moveMap.bind(keyboard, "7", useSeventhSlot);
moveMap.bind(keyboard, "8", useEighthSlot);
moveMap.bind(keyboard, "9", useNinthSlot);
moveMap.bind(keyboard, "0", useTenthSlot);
moveMap.bind(keyboard, "ctrl z", undoBrick);
moveMap.bind(keyboard, "lalt", toggleSuperShift);
moveMap.bind(keyboard, "ctrl a", openAdminWindow);
moveMap.bind(keyboard, "ctrl o", openOptionsWindow);
moveMap.bind(keyboard, "ctrl p", doScreenShot);
moveMap.bind(keyboard, "ctrl k", Suicide);
moveMap.bind(keyboard, "shift p", doHudScreenshot);
moveMap.bind(keyboard, "shift-ctrl p", doDofScreenShot);
moveMap.bind(keyboard, "f2", showPlayerList);
moveMap.bind(keyboard, "ctrl n", toggleNetGraph);
moveMap.bind(keyboard, "b", openBSD);
moveMap.bind(keyboard, "f5", ToggleShapeNameHud);
moveMap.bind(keyboard, "period", NextSeat);
moveMap.bind(keyboard, "comma", PrevSeat);
moveMap.bind(keyboard, "numpad8", shiftBrickAway);
moveMap.bind(keyboard, "numpad2", shiftBrickTowards);
moveMap.bind(keyboard, "numpad4", shiftBrickLeft);
moveMap.bind(keyboard, "numpad6", shiftBrickRight);
moveMap.bind(keyboard, "+", shiftBrickUp);
moveMap.bind(keyboard, "numpad5", shiftBrickDown);
moveMap.bind(keyboard, "numpad3", shiftBrickThirdUp);
moveMap.bind(keyboard, "numpad1", shiftBrickThirdDown);
moveMap.bind(keyboard, "numpad9", RotateBrickCW);
moveMap.bind(keyboard, "numpad7", RotateBrickCCW);
moveMap.bind(keyboard, "numpadenter", plantBrick);
moveMap.bind(keyboard, "numpad0", cancelBrick);
moveMap.bind(keyboard, "ctrl numpad0", ToggleBuildMacroRecording);
moveMap.bind(keyboard, "ctrl numpadenter", PlayBackBuildMacro);
moveMap.bind(keyboard, "l", useLight);
moveMap.bind(keyboard, "alt numpad8", superShiftBrickAwayProxy);
moveMap.bind(keyboard, "alt numpad2", superShiftBrickTowardsProxy);
moveMap.bind(keyboard, "alt numpad4", superShiftBrickLeftProxy);
moveMap.bind(keyboard, "alt numpad6", superShiftBrickRightProxy);
moveMap.bind(keyboard, "alt +", superShiftBrickUpProxy);
moveMap.bind(keyboard, "alt numpad5", superShiftBrickDownProxy);
moveMap.bind(keyboard, "ctrl e", invLeft);
moveMap.bind(mouse0, "xaxis", yaw);
moveMap.bind(mouse0, "yaxis", pitch);
moveMap.bind(mouse0, "button0", mouseFire);
moveMap.bind(mouse0, "button1", Jet);
moveMap.bind(mouse0, "zaxis", scrollInventory);
